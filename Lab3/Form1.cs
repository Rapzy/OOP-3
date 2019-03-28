using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Lab3
{
    public partial class Form1 : Form
    {
        List<Steelarm> steelarms = new List<Steelarm>();
        List<Rifle> rifles = new List<Rifle>();
        List<Pistol> pistols = new List<Pistol>();
        List<Gun> guns = new List<Gun>();
        List<Type> gun_types = new List<Type>();
        IEnumerable<Type> subclasses;
        int offset = 20;
        const int margin = 40;
        int param_number = 0;
        public Form1()
        {
            InitializeComponent();
            comboBox1.Format += (s, e) => {
                e.Value = ((TypeInfo)e.Value).type.Name;
            };
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "Name";
            subclasses = Assembly
           .GetAssembly(typeof(Gun))
           .GetTypes()
           .Where(t => t.IsSubclassOf(typeof(Gun)));
            FillTypeComboBox();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            param_number = 0;
            offset = 20;
            foreach (ParameterInfo parameter in (comboBox1.SelectedItem as TypeInfo).parameters)
            {
                AddField(TransformPropName(parameter.Name));                                
            }
        }
        public string TransformPropName(string prop)
        {
            return prop.First().ToString().ToUpper()+prop.Substring(1).Replace("_", " ");
        }
        public string GetTextBoxName(string prop_name, int id = 0)
        {
            return prop_name.Replace(" ", "") + "TextBox" + id.ToString();
        }
        public void AddField(string name)
        {
            TextBox txt = new TextBox();
            txt.Name = GetTextBoxName(name, 1);
            txt.Height = 15;
            txt.Width = 150;
            txt.Top = offset;
            panel1.Controls.Add(txt);

            Label lbl = new Label();
            lbl.Text = name;
            lbl.Top = offset - 15;
            panel1.Controls.Add(lbl);
            offset += margin;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TypeInfo selected_type = (comboBox1.SelectedItem as TypeInfo);
            List<object> input = new List<object>();
            TextBox[] textBoxes = panel1.Controls.OfType<TextBox>().ToArray();
            for (int i=0; i<selected_type.parameters.Count(); i++)
            {
                input.Add(Convert.ChangeType(textBoxes[i].Text, selected_type.parameters[i].ParameterType));
            }
            Object[] args = input.ToArray();
            Gun new_gun = (Gun)Activator.CreateInstance(selected_type.type, args);
            comboBox2.Items.Clear();
            guns.Add(new_gun);
            foreach (Gun gun in guns)
            {
                comboBox2.Items.Add(gun);
            }
            comboBox2.SelectedIndex = 0;
            foreach (Control obj in panel1.Controls)
            {
                if (obj is TextBox)
                {
                    obj.ResetText();
                }
            }
            UpdateInfo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            object selected = comboBox2.SelectedItem;
            GetGunType(selected).Shoot();
            UpdateInfo();
        }
        public Gun GetGunType(object obj)
        {
            if (obj is Steelarm)
            {
                return (Steelarm)obj;
            }
            else if (obj is Pistol)
            {
                return (Pistol)obj;
            }
            else if (obj is Rifle)
            {
                return (Rifle)obj;
            }
            return (Firearm)obj;
        }
        public void UpdateInfo()
        {
            foreach (Label obj in panel2.Controls)
            {
                obj.Text = obj.Text.Substring(0, obj.Text.IndexOf(": ") + 2);
            }
            InfoAmmo.Visible = false;
            InfoRate.Visible = false;
            Gun selected = GetGunType(comboBox2.SelectedItem);
            InfoName.Text += selected.name;
            InfoType.Text += selected.type;
            InfoDiscription.Text += selected.GetFullType();
            if (selected is Firearm)
            {
                InfoAmmo.Text += (selected as Firearm).ammo.ToString()+"/"+ (selected as Firearm).clip_size;
                InfoAmmo.Visible = true;
            }
            if (selected is Rifle)
            { 
                InfoRate.Text += (selected as Rifle).fire_rate.ToString();
                InfoAmmo.Visible = true;
                InfoRate.Visible = true;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateInfo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Gun selected = GetGunType(comboBox2.SelectedItem);
            if (selected is Firearm)
            {
                (selected as Firearm).Reload();
            }
            UpdateInfo();
        }
        public class TypeInfo
        {
            public Type type;
            public ParameterInfo[] parameters;
            public TypeInfo() { }
        }
        public void FillTypeComboBox()
        {
            foreach (Type type in subclasses)
            {
                if (!type.IsAbstract)
                {
                    TypeInfo new_type = new TypeInfo();
                    new_type.type = type;
                    ConstructorInfo[] constructors = type.GetConstructors();
                    foreach (ConstructorInfo constructor in constructors)
                    {
                        ParameterInfo[] parameters = constructor.GetParameters();
                        if (parameters.Count() > 0)
                        {
                            new_type.parameters = parameters;
                            break;
                        }
                    }
                    comboBox1.Items.Add(new_type);
                }
            }
            comboBox1.SelectedIndex = 0;
        }
    }
}

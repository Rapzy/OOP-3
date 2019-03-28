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
        public Form1()
        {
            InitializeComponent();
            comboBox1.Format += (s, e) => {
                e.Value = ((TypeInfo)e.Value).type.Name;
            };
            comboBox2.DisplayMember = "Name";
            subclasses = Assembly
           .GetAssembly(typeof(Gun))
           .GetTypes()
           .Where(t => t.IsSubclassOf(typeof(Gun)));
            FillTypeComboBox();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            offset = 20;
            foreach (ParameterInfo parameter in (comboBox1.SelectedItem as TypeInfo).parameters)
            {
                AddField(parameter, panel1, 1);                                
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateInfo();
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
            Type t = Type.GetType(comboBox2.SelectedItem.ToString());
            dynamic selected_gun = Convert.ChangeType(comboBox2.SelectedItem, t);
            selected_gun.Shoot();
            UpdateInfo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Type t = Type.GetType(comboBox2.SelectedItem.ToString());
            if (t.GetMethod("Reload") != null)
            {
                dynamic selected_gun = Convert.ChangeType(comboBox2.SelectedItem, t);
                selected_gun.Reload();
                UpdateInfo();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }
        public void UpdateInfo()
        {
            Gun obj = (Gun)comboBox2.SelectedItem;
            panel2.Controls.Clear();
            offset = 20;
            Type t = Type.GetType(comboBox2.SelectedItem.ToString());
            PropertyInfo[] properties = obj.GetType().GetProperties();
            foreach (PropertyInfo property in properties)
            {
                AddField(property, panel2, 2, property.GetValue(obj).ToString());
            }
        }
        public class TypeInfo
        {
            public Type type;
            public ParameterInfo[] parameters;
            public TypeInfo() { }
        }
        public void AddField(ParameterInfo parameter, Panel parent, int id)
        {
            string name = TransformPropName(parameter.Name);
            TextBox txt = new TextBox();
            txt.Name = GetTextBoxName(name, id);
            txt.Height = 15;
            txt.Width = 150;
            txt.Top = offset;
            parent.Controls.Add(txt);

            Label lbl = new Label();
            lbl.Text = name;
            lbl.Top = offset - 15;
            parent.Controls.Add(lbl);
            offset += margin;
        }
        public void AddField(PropertyInfo property, Panel parent, int id, string value)
        {
            string name = TransformPropName(property.Name);
            TextBox txt = new TextBox();
            txt.Name = GetTextBoxName(name, id);
            txt.Height = 15;
            txt.Width = 150;
            txt.Top = offset;
            txt.Text = value;
            txt.Enabled = property.SetMethod.IsPublic;
            parent.Controls.Add(txt);

            Label lbl = new Label();
            lbl.Text = name;
            lbl.Top = offset - 15;
            parent.Controls.Add(lbl);
            offset += margin;
        }
        public string TransformPropName(string prop)
        {
            return prop.First().ToString().ToUpper() + prop.Substring(1).Replace("_", " ");
        }
        public string GetTextBoxName(string prop_name, int id = 0)
        {
            return prop_name.Replace(" ", "") + "TextBox" + id.ToString();
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

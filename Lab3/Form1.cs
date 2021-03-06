﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Lab3
{
    public partial class Form1 : Form
    {
        struct selected_gun_struct
        {
            public dynamic obj;
            public Type type;
        }
        selected_gun_struct selected_gun; 
        List<Gun> guns = new List<Gun>();
        List<Type> gun_types = new List<Type>();
        List<Gun> serialization_list = new List<Gun>();
        IEnumerable<Type> subclasses;
        int offset = 20;
        const int margin = 40;
        public Form1()
        {
            selected_gun = new selected_gun_struct();
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
            object[] args = input.ToArray();
            Gun new_gun = (Gun)Activator.CreateInstance(selected_type.type, args);
            guns.Add(new_gun);
            UpdateGunList();
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
            selected_gun.obj.Shoot();
            UpdateInfo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (selected_gun.type.GetMethod("Reload") != null)
            {
                selected_gun.obj.Reload();
                UpdateInfo();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            foreach(PropertyInfo property in selected_gun.type.GetProperties())
            {
                string txt = panel2.Controls[GetTextBoxName(TransformPropName(property.Name), 2)].Text;
                property.SetValue(selected_gun.obj, Convert.ChangeType(txt ,property.PropertyType));
            }
            UpdateInfo();
            UpdateGunList();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            int idx = serialization_list.IndexOf(selected_gun.obj); //index of object in @serialization_list
            if (idx == -1) //check if object already in @serialization_list
            {
                serialization_list.Add(selected_gun.obj);
                textBox1.Text += selected_gun.type.GetProperty("name").GetValue(selected_gun.obj) + Environment.NewLine;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fs = new FileStream("Guns.dat", FileMode.OpenOrCreate);
            formatter.Serialize(fs, serialization_list.ToArray());
            fs.Close();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fs = new FileStream("Guns.dat", FileMode.Open);
            Gun[] loaded_guns = (Gun[])formatter.Deserialize(fs);
            foreach (Gun loaded_gun in loaded_guns)
            {
                guns.Add(loaded_gun);
            }
            UpdateGunList();
            fs.Close();
        }
        public void UpdateInfo()
        {
            selected_gun.type = Type.GetType(comboBox2.SelectedItem.ToString());
            selected_gun.obj = Convert.ChangeType(comboBox2.SelectedItem, selected_gun.type); ;
            panel2.Controls.Clear();
            offset = 20;
            PropertyInfo[] properties = selected_gun.obj.GetType().GetProperties();
            foreach (PropertyInfo property in properties)
            {
                AddField(property, panel2, 2, property.GetValue(selected_gun.obj).ToString());
            }
        }
        public void UpdateGunList()
        {
            comboBox2.Items.Clear();
            foreach (Gun gun in guns)
            {
                comboBox2.Items.Add(gun);
            }
            comboBox2.SelectedIndex = 0;
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
                if (!type.IsAbstract && type.IsSerializable)
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

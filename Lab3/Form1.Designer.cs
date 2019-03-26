namespace Lab3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.InfoAmmo = new System.Windows.Forms.Label();
            this.InfoType = new System.Windows.Forms.Label();
            this.InfoName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.InfoRate = new System.Windows.Forms.Label();
            this.InfoDiscription = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Steel Arm",
            "Pistol",
            "Rifle"});
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "Create Gun";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 282);
            this.panel1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(572, 12);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(171, 24);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(572, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 38);
            this.button2.TabIndex = 4;
            this.button2.Text = "Shoot";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.InfoDiscription);
            this.panel2.Controls.Add(this.InfoRate);
            this.panel2.Controls.Add(this.InfoAmmo);
            this.panel2.Controls.Add(this.InfoType);
            this.panel2.Controls.Add(this.InfoName);
            this.panel2.Location = new System.Drawing.Point(572, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(377, 170);
            this.panel2.TabIndex = 5;
            // 
            // InfoAmmo
            // 
            this.InfoAmmo.AutoSize = true;
            this.InfoAmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoAmmo.Location = new System.Drawing.Point(3, 100);
            this.InfoAmmo.Name = "InfoAmmo";
            this.InfoAmmo.Size = new System.Drawing.Size(80, 25);
            this.InfoAmmo.TabIndex = 2;
            this.InfoAmmo.Text = "Ammo: ";
            // 
            // InfoType
            // 
            this.InfoType.AutoSize = true;
            this.InfoType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoType.Location = new System.Drawing.Point(3, 40);
            this.InfoType.Name = "InfoType";
            this.InfoType.Size = new System.Drawing.Size(68, 25);
            this.InfoType.TabIndex = 1;
            this.InfoType.Text = "Type: ";
            // 
            // InfoName
            // 
            this.InfoName.AutoSize = true;
            this.InfoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoName.Location = new System.Drawing.Point(3, 10);
            this.InfoName.Name = "InfoName";
            this.InfoName.Size = new System.Drawing.Size(75, 25);
            this.InfoName.TabIndex = 0;
            this.InfoName.Text = "Name: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(569, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gun Info";
            // 
            // InfoRate
            // 
            this.InfoRate.AutoSize = true;
            this.InfoRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoRate.Location = new System.Drawing.Point(3, 130);
            this.InfoRate.Name = "InfoRate";
            this.InfoRate.Size = new System.Drawing.Size(101, 25);
            this.InfoRate.TabIndex = 3;
            this.InfoRate.Text = "Fire Rate: ";
            // 
            // InfoDiscription
            // 
            this.InfoDiscription.AutoSize = true;
            this.InfoDiscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoDiscription.Location = new System.Drawing.Point(3, 70);
            this.InfoDiscription.Name = "InfoDiscription";
            this.InfoDiscription.Size = new System.Drawing.Size(113, 25);
            this.InfoDiscription.TabIndex = 4;
            this.InfoDiscription.Text = "Discription: ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(763, 286);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 38);
            this.button3.TabIndex = 5;
            this.button3.Text = "Reload";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 537);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label InfoAmmo;
        private System.Windows.Forms.Label InfoType;
        private System.Windows.Forms.Label InfoName;
        private System.Windows.Forms.Label InfoDiscription;
        private System.Windows.Forms.Label InfoRate;
        private System.Windows.Forms.Button button3;
    }
}


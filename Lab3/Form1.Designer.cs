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
            this.InfoDiscription = new System.Windows.Forms.Label();
            this.InfoRate = new System.Windows.Forms.Label();
            this.InfoAmmo = new System.Windows.Forms.Label();
            this.InfoType = new System.Windows.Forms.Label();
            this.InfoName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 10);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 268);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Create Gun";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(9, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 229);
            this.panel1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(429, 10);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(129, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(429, 232);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 31);
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
            this.panel2.Location = new System.Drawing.Point(429, 50);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 138);
            this.panel2.TabIndex = 5;
            // 
            // InfoDiscription
            // 
            this.InfoDiscription.AutoSize = true;
            this.InfoDiscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoDiscription.Location = new System.Drawing.Point(2, 57);
            this.InfoDiscription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InfoDiscription.Name = "InfoDiscription";
            this.InfoDiscription.Size = new System.Drawing.Size(91, 20);
            this.InfoDiscription.TabIndex = 4;
            this.InfoDiscription.Text = "Discription: ";
            // 
            // InfoRate
            // 
            this.InfoRate.AutoSize = true;
            this.InfoRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoRate.Location = new System.Drawing.Point(2, 106);
            this.InfoRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InfoRate.Name = "InfoRate";
            this.InfoRate.Size = new System.Drawing.Size(83, 20);
            this.InfoRate.TabIndex = 3;
            this.InfoRate.Text = "Fire Rate: ";
            // 
            // InfoAmmo
            // 
            this.InfoAmmo.AutoSize = true;
            this.InfoAmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoAmmo.Location = new System.Drawing.Point(2, 81);
            this.InfoAmmo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InfoAmmo.Name = "InfoAmmo";
            this.InfoAmmo.Size = new System.Drawing.Size(63, 20);
            this.InfoAmmo.TabIndex = 2;
            this.InfoAmmo.Text = "Ammo: ";
            // 
            // InfoType
            // 
            this.InfoType.AutoSize = true;
            this.InfoType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoType.Location = new System.Drawing.Point(2, 32);
            this.InfoType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InfoType.Name = "InfoType";
            this.InfoType.Size = new System.Drawing.Size(51, 20);
            this.InfoType.TabIndex = 1;
            this.InfoType.Text = "Type: ";
            // 
            // InfoName
            // 
            this.InfoName.AutoSize = true;
            this.InfoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoName.Location = new System.Drawing.Point(2, 8);
            this.InfoName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InfoName.Name = "InfoName";
            this.InfoName.Size = new System.Drawing.Size(59, 20);
            this.InfoName.TabIndex = 0;
            this.InfoName.Text = "Name: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(427, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gun Info";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(572, 232);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 31);
            this.button3.TabIndex = 5;
            this.button3.Text = "Reload";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 436);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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


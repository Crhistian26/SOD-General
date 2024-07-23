namespace SOD_General
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cR_Label2 = new CR_LabelUp();
            this.cR_Label1 = new CR_LabelUp();
            this.textBox2 = new Designer.FR_TextBox();
            this.textBox1 = new Designer.FR_TextBox();
            this.botones_Nuevos1 = new Diseños.Botones_Nuevos();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cR_Label2
            // 
            this.cR_Label2.AutoSize = true;
            this.cR_Label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.cR_Label2.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.cR_Label2.ForeColor = System.Drawing.Color.White;
            this.cR_Label2.Location = new System.Drawing.Point(75, 17);
            this.cR_Label2.Name = "cR_Label2";
            this.cR_Label2.Size = new System.Drawing.Size(60, 20);
            this.cR_Label2.TabIndex = 11;
            this.cR_Label2.Text = "Usuario";
            // 
            // cR_Label1
            // 
            this.cR_Label1.AutoSize = true;
            this.cR_Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.cR_Label1.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.cR_Label1.ForeColor = System.Drawing.Color.White;
            this.cR_Label1.Location = new System.Drawing.Point(75, 90);
            this.cR_Label1.Name = "cR_Label1";
            this.cR_Label1.Size = new System.Drawing.Size(85, 20);
            this.cR_Label1.TabIndex = 10;
            this.cR_Label1.Text = "Contraseña";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(123)))), ((int)(((byte)(134)))));
            this.textBox2.BorderFocusColor = System.Drawing.Color.Blue;
            this.textBox2.BorderSize = 2;
            this.textBox2.Location = new System.Drawing.Point(75, 118);
            this.textBox2.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Padding = new System.Windows.Forms.Padding(7);
            this.textBox2.PasswordChar = false;
            this.textBox2.Size = new System.Drawing.Size(270, 30);
            this.textBox2.TabIndex = 8;
            this.textBox2.texts = "";
            this.textBox2.UnderlinedStyle = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(123)))), ((int)(((byte)(134)))));
            this.textBox1.BorderFocusColor = System.Drawing.Color.Blue;
            this.textBox1.BorderSize = 2;
            this.textBox1.Location = new System.Drawing.Point(75, 48);
            this.textBox1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Padding = new System.Windows.Forms.Padding(7);
            this.textBox1.PasswordChar = false;
            this.textBox1.Size = new System.Drawing.Size(270, 30);
            this.textBox1.TabIndex = 7;
            this.textBox1.texts = "";
            this.textBox1.UnderlinedStyle = false;
            // 
            // botones_Nuevos1
            // 
            this.botones_Nuevos1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(123)))), ((int)(((byte)(134)))));
            this.botones_Nuevos1.BorderColor = System.Drawing.Color.Teal;
            this.botones_Nuevos1.BorderRadius = 40;
            this.botones_Nuevos1.BorderSize = 0;
            this.botones_Nuevos1.FlatAppearance.BorderSize = 0;
            this.botones_Nuevos1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botones_Nuevos1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.botones_Nuevos1.ForeColor = System.Drawing.Color.White;
            this.botones_Nuevos1.Location = new System.Drawing.Point(144, 180);
            this.botones_Nuevos1.Name = "botones_Nuevos1";
            this.botones_Nuevos1.Size = new System.Drawing.Size(150, 41);
            this.botones_Nuevos1.TabIndex = 0;
            this.botones_Nuevos1.Text = "Ingresar";
            this.botones_Nuevos1.UseVisualStyleBackColor = false;
            this.botones_Nuevos1.Click += new System.EventHandler(this.botones_Nuevos1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Libreta Casio Gris",
            "Libreta Casio Verde",
            "Libreta Eduart Azul",
            "Libreta Eduart Gris"});
            this.comboBox1.Location = new System.Drawing.Point(317, 159);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.ClientSize = new System.Drawing.Size(450, 240);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cR_Label2);
            this.Controls.Add(this.cR_Label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.botones_Nuevos1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(450, 240);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Diseños.Botones_Nuevos botones_Nuevos1;
        private CR_LabelUp cR_Label1;
        private CR_LabelUp cR_Label2;
        private Designer.FR_TextBox textBox1;
        private Designer.FR_TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
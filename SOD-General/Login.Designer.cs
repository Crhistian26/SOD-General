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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.cr_Textbox2 = new Cr_Textbox();
            this.cr_Textbox1 = new Cr_Textbox();
            this.cR_Label2 = new CR_LabelUp();
            this.cR_Label1 = new CR_LabelUp();
            this.btn_Login = new Diseños.Botones_Nuevos();
            this.SuspendLayout();
            // 
            // cr_Textbox2
            // 
            this.cr_Textbox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cr_Textbox2.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.cr_Textbox2.Location = new System.Drawing.Point(79, 113);
            this.cr_Textbox2.Name = "cr_Textbox2";
            this.cr_Textbox2.PasswordChar = '*';
            this.cr_Textbox2.Size = new System.Drawing.Size(284, 25);
            this.cr_Textbox2.TabIndex = 13;
            // 
            // cr_Textbox1
            // 
            this.cr_Textbox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cr_Textbox1.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.cr_Textbox1.Location = new System.Drawing.Point(79, 41);
            this.cr_Textbox1.Name = "cr_Textbox1";
            this.cr_Textbox1.Size = new System.Drawing.Size(284, 25);
            this.cr_Textbox1.TabIndex = 12;
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
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(123)))), ((int)(((byte)(134)))));
            this.btn_Login.BorderColor = System.Drawing.Color.Teal;
            this.btn_Login.BorderRadius = 40;
            this.btn_Login.BorderSize = 0;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(144, 180);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(150, 41);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "Ingresar";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.ClientSize = new System.Drawing.Size(450, 240);
            this.Controls.Add(this.cr_Textbox2);
            this.Controls.Add(this.cr_Textbox1);
            this.Controls.Add(this.cR_Label2);
            this.Controls.Add(this.cR_Label1);
            this.Controls.Add(this.btn_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(450, 240);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Diseños.Botones_Nuevos btn_Login;
        private CR_LabelUp cR_Label1;
        private CR_LabelUp cR_Label2;
        private Cr_Textbox cr_Textbox1;
        private Cr_Textbox cr_Textbox2;
    }
}
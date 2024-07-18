namespace SOD_General
{
    partial class VistaPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.fR_ComboBox1 = new Designer.FR_ComboBox();
            this.fR_ComboBox2 = new Designer.FR_ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fR_ComboBox2);
            this.panel1.Controls.Add(this.fR_ComboBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // fR_ComboBox1
            // 
            this.fR_ComboBox1.BackColor = System.Drawing.Color.White;
            this.fR_ComboBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(123)))), ((int)(((byte)(134)))));
            this.fR_ComboBox1.BorderSize = 2;
            this.fR_ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.fR_ComboBox1.IconColor = System.Drawing.Color.White;
            this.fR_ComboBox1.ListBackColor = System.Drawing.Color.LightBlue;
            this.fR_ComboBox1.ListTextColor = System.Drawing.Color.Black;
            this.fR_ComboBox1.Location = new System.Drawing.Point(431, 90);
            this.fR_ComboBox1.MinimumSize = new System.Drawing.Size(200, 30);
            this.fR_ComboBox1.Name = "fR_ComboBox1";
            this.fR_ComboBox1.Padding = new System.Windows.Forms.Padding(2);
            this.fR_ComboBox1.Size = new System.Drawing.Size(200, 30);
            this.fR_ComboBox1.TabIndex = 0;
            this.fR_ComboBox1.Texto = "";
            // 
            // fR_ComboBox2
            // 
            this.fR_ComboBox2.BackColor = System.Drawing.Color.White;
            this.fR_ComboBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(123)))), ((int)(((byte)(134)))));
            this.fR_ComboBox2.BorderSize = 2;
            this.fR_ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.fR_ComboBox2.IconColor = System.Drawing.Color.White;
            this.fR_ComboBox2.ListBackColor = System.Drawing.Color.LightBlue;
            this.fR_ComboBox2.ListTextColor = System.Drawing.Color.Black;
            this.fR_ComboBox2.Location = new System.Drawing.Point(193, 90);
            this.fR_ComboBox2.MinimumSize = new System.Drawing.Size(200, 30);
            this.fR_ComboBox2.Name = "fR_ComboBox2";
            this.fR_ComboBox2.Padding = new System.Windows.Forms.Padding(2);
            this.fR_ComboBox2.Size = new System.Drawing.Size(200, 30);
            this.fR_ComboBox2.TabIndex = 1;
            this.fR_ComboBox2.Texto = "";
            // 
            // VistaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "VistaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VistaPrincipal";
            this.Load += new System.EventHandler(this.VistaPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private Designer.FR_ComboBox fR_ComboBox2;
        private Designer.FR_ComboBox fR_ComboBox1;
    }
}
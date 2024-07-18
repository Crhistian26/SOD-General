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
            this.fR_TextBox1 = new Designer.FR_TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fR_TextBox1);
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
            // fR_TextBox1
            // 
            this.fR_TextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.fR_TextBox1.BorderColor = System.Drawing.Color.Teal;
            this.fR_TextBox1.BorderFocusColor = System.Drawing.Color.Red;
            this.fR_TextBox1.BorderSize = 2;
            this.fR_TextBox1.Location = new System.Drawing.Point(285, 146);
            this.fR_TextBox1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.fR_TextBox1.Multiline = true;
            this.fR_TextBox1.Name = "fR_TextBox1";
            this.fR_TextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.fR_TextBox1.PasswordChar = false;
            this.fR_TextBox1.Size = new System.Drawing.Size(270, 30);
            this.fR_TextBox1.TabIndex = 0;
            this.fR_TextBox1.texts = "";
            this.fR_TextBox1.UnderlinedStyle = false;
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
        private Designer.FR_TextBox fR_TextBox1;
    }
}
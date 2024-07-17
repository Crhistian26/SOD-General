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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.botones_Nuevos2 = new Diseños.Botones_Nuevos();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // botones_Nuevos2
            // 
            this.botones_Nuevos2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(123)))), ((int)(((byte)(134)))));
            this.botones_Nuevos2.BorderColor = System.Drawing.Color.Teal;
            this.botones_Nuevos2.BorderRadius = 40;
            this.botones_Nuevos2.BorderSize = 0;
            this.botones_Nuevos2.FlatAppearance.BorderSize = 0;
            this.botones_Nuevos2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botones_Nuevos2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.botones_Nuevos2.ForeColor = System.Drawing.Color.White;
            this.botones_Nuevos2.Location = new System.Drawing.Point(477, 117);
            this.botones_Nuevos2.Name = "botones_Nuevos2";
            this.botones_Nuevos2.Size = new System.Drawing.Size(150, 40);
            this.botones_Nuevos2.TabIndex = 2;
            this.botones_Nuevos2.Text = "botones_Nuevos2";
            this.botones_Nuevos2.UseVisualStyleBackColor = false;
            // 
            // VistaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botones_Nuevos2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VistaPrincipal";
            this.Text = "VistaPrincipal";
            this.Load += new System.EventHandler(this.VistaPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private Diseños.Botones_Nuevos botones_Nuevos2;
    }
}
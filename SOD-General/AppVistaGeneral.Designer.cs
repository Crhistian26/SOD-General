namespace SOD_General
{
    partial class AppVistaGeneral
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cR_MenuStrip1 = new CR_MenuStrip();
            this.hoalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1173, 548);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::SOD_General.Properties.Resources.logo_sod_soluciones_diaz_fixed;
            this.pictureBox1.Location = new System.Drawing.Point(385, 223);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(400, 94);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(400, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 94);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // cR_MenuStrip1
            // 
            this.cR_MenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.cR_MenuStrip1.ForeColor = System.Drawing.Color.White;
            this.cR_MenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cR_MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.cR_MenuStrip1.Name = "cR_MenuStrip1";
            this.cR_MenuStrip1.Size = new System.Drawing.Size(1173, 24);
            this.cR_MenuStrip1.TabIndex = 2;
            this.cR_MenuStrip1.Text = "cR_MenuStrip1";
            // 
            // hoalToolStripMenuItem
            // 
            this.hoalToolStripMenuItem.Name = "hoalToolStripMenuItem";
            this.hoalToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hoalToolStripMenuItem.Text = "Hoal";
            // 
            // AppVistaGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 572);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cR_MenuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AppVistaGeneral";
            this.Text = "AppVistaGeneal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AppVistaGeneral_Load);
            this.Resize += new System.EventHandler(this.AppVistaGeneral_Resize);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem hoalToolStripMenuItem;
        public CR_MenuStrip cR_MenuStrip1;
        public System.Windows.Forms.Panel panel1;

    }
}
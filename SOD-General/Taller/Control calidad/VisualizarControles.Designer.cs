namespace SOD_General.Taller.Control_calidad
{
    partial class VisualizarControles
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cR_MenuStrip1 = new CR_MenuStrip();
            this.holaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adfafdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adfafToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.cR_MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cR_MenuStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 110;
            this.splitContainer1.TabIndex = 0;
            // 
            // cR_MenuStrip1
            // 
            this.cR_MenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.cR_MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.holaToolStripMenuItem});
            this.cR_MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.cR_MenuStrip1.Name = "cR_MenuStrip1";
            this.cR_MenuStrip1.Size = new System.Drawing.Size(800, 24);
            this.cR_MenuStrip1.TabIndex = 0;
            this.cR_MenuStrip1.Text = "cR_MenuStrip1";
            // 
            // holaToolStripMenuItem
            // 
            this.holaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adfafdToolStripMenuItem,
            this.adfafToolStripMenuItem});
            this.holaToolStripMenuItem.Name = "holaToolStripMenuItem";
            this.holaToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.holaToolStripMenuItem.Text = "Hola";
            // 
            // adfafdToolStripMenuItem
            // 
            this.adfafdToolStripMenuItem.Name = "adfafdToolStripMenuItem";
            this.adfafdToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adfafdToolStripMenuItem.Text = "adfafd";
            // 
            // adfafToolStripMenuItem
            // 
            this.adfafToolStripMenuItem.Name = "adfafToolStripMenuItem";
            this.adfafToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adfafToolStripMenuItem.Text = "adfaf";
            // 
            // VisualizarControles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.cR_MenuStrip1;
            this.Name = "VisualizarControles";
            this.Text = "VisualizarControles";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.cR_MenuStrip1.ResumeLayout(false);
            this.cR_MenuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private CR_MenuStrip cR_MenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem holaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adfafdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adfafToolStripMenuItem;
    }
}
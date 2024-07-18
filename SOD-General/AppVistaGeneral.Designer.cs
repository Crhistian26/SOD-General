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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tallerRecepcionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPeticionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fR_ComboBox1 = new Designer.FR_ComboBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tallerRecepcionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // tallerRecepcionToolStripMenuItem
            // 
            this.tallerRecepcionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verPeticionesToolStripMenuItem});
            this.tallerRecepcionToolStripMenuItem.Name = "tallerRecepcionToolStripMenuItem";
            this.tallerRecepcionToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.tallerRecepcionToolStripMenuItem.Text = "Taller Recepcion";
            // 
            // verPeticionesToolStripMenuItem
            // 
            this.verPeticionesToolStripMenuItem.Name = "verPeticionesToolStripMenuItem";
            this.verPeticionesToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.verPeticionesToolStripMenuItem.Text = "Ver peticiones";
            this.verPeticionesToolStripMenuItem.Click += new System.EventHandler(this.verPeticionesToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fR_ComboBox1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 426);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(422, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // fR_ComboBox1
            // 
            this.fR_ComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(123)))), ((int)(((byte)(134)))));
            this.fR_ComboBox1.Location = new System.Drawing.Point(64, 73);
            this.fR_ComboBox1.MinimumSize = new System.Drawing.Size(200, 30);
            this.fR_ComboBox1.Name = "fR_ComboBox1";
            this.fR_ComboBox1.Padding = new System.Windows.Forms.Padding(2);
            this.fR_ComboBox1.Size = new System.Drawing.Size(200, 30);
            this.fR_ComboBox1.TabIndex = 1;
            // 
            // AppVistaGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AppVistaGeneral";
            this.Text = "AppVistaGeneal";
            this.Load += new System.EventHandler(this.AppVistaGeneral_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tallerRecepcionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPeticionesToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Designer.FR_ComboBox fR_ComboBox1;
    }
}
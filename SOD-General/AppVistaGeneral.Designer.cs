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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.botones_Nuevos1 = new Diseños.Botones_Nuevos();
            this.fR_TextBox2 = new Designer.FR_TextBox();
            this.fR_TextBox1 = new Designer.FR_TextBox();
            this.fR_ComboBox1 = new Designer.FR_ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(422, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fR_ComboBox1);
            this.panel1.Controls.Add(this.botones_Nuevos1);
            this.panel1.Controls.Add(this.fR_TextBox2);
            this.panel1.Controls.Add(this.fR_TextBox1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 426);
            this.panel1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(302, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.botones_Nuevos1.Location = new System.Drawing.Point(233, 192);
            this.botones_Nuevos1.Name = "botones_Nuevos1";
            this.botones_Nuevos1.Size = new System.Drawing.Size(175, 39);
            this.botones_Nuevos1.TabIndex = 4;
            this.botones_Nuevos1.Text = "botones_Nuevos1";
            this.botones_Nuevos1.UseVisualStyleBackColor = false;
            // 
            // fR_TextBox2
            // 
            this.fR_TextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.fR_TextBox2.BorderColor = System.Drawing.Color.Teal;
            this.fR_TextBox2.BorderFocusColor = System.Drawing.Color.Red;
            this.fR_TextBox2.BorderSize = 2;
            this.fR_TextBox2.Location = new System.Drawing.Point(237, 157);
            this.fR_TextBox2.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.fR_TextBox2.Multiline = true;
            this.fR_TextBox2.Name = "fR_TextBox2";
            this.fR_TextBox2.Padding = new System.Windows.Forms.Padding(7);
            this.fR_TextBox2.PasswordChar = false;
            this.fR_TextBox2.Size = new System.Drawing.Size(175, 30);
            this.fR_TextBox2.TabIndex = 3;
            this.fR_TextBox2.texts = "";
            this.fR_TextBox2.UnderlinedStyle = false;
            // 
            // fR_TextBox1
            // 
            this.fR_TextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.fR_TextBox1.BorderColor = System.Drawing.Color.Teal;
            this.fR_TextBox1.BorderFocusColor = System.Drawing.Color.Red;
            this.fR_TextBox1.BorderSize = 2;
            this.fR_TextBox1.Location = new System.Drawing.Point(25, 157);
            this.fR_TextBox1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.fR_TextBox1.Multiline = true;
            this.fR_TextBox1.Name = "fR_TextBox1";
            this.fR_TextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.fR_TextBox1.PasswordChar = false;
            this.fR_TextBox1.Size = new System.Drawing.Size(175, 30);
            this.fR_TextBox1.TabIndex = 2;
            this.fR_TextBox1.texts = "";
            this.fR_TextBox1.UnderlinedStyle = false;
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
            this.fR_ComboBox1.Location = new System.Drawing.Point(63, 50);
            this.fR_ComboBox1.MinimumSize = new System.Drawing.Size(200, 30);
            this.fR_ComboBox1.Name = "fR_ComboBox1";
            this.fR_ComboBox1.Padding = new System.Windows.Forms.Padding(2);
            this.fR_ComboBox1.Size = new System.Drawing.Size(200, 30);
            this.fR_ComboBox1.TabIndex = 5;
            this.fR_ComboBox1.Texto = "";
            this.fR_ComboBox1.Load += new System.EventHandler(this.fR_ComboBox1_Load);
            // 
            // AppVistaGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AppVistaGeneral";
            this.Text = "AppVistaGeneal";
            this.Load += new System.EventHandler(this.AppVistaGeneral_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tallerRecepcionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPeticionesToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private Diseños.Botones_Nuevos botones_Nuevos1;
        private Designer.FR_TextBox fR_TextBox2;
        private Designer.FR_TextBox fR_TextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private Designer.FR_ComboBox fR_ComboBox1;
    }
}
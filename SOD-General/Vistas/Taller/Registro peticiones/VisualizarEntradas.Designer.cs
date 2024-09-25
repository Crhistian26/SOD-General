namespace SOD_General.Vistas.Taller.Registrar_entrada
{
    partial class VisualizarEntradas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cR_SplitContainer1 = new CR_SplitContainer();
            this.cR_Subtitulos1 = new CR_Subtitulos();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvEntrys = new CR_DataGriedView();
            this.cR_DataGriedView1 = new CR_DataGriedView();
            this.cR_LabelDown1 = new CR_LabelDown();
            this.cR_LabelDown2 = new CR_LabelDown();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.cR_SplitContainer1)).BeginInit();
            this.cR_SplitContainer1.Panel1.SuspendLayout();
            this.cR_SplitContainer1.Panel2.SuspendLayout();
            this.cR_SplitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cR_DataGriedView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cR_SplitContainer1
            // 
            this.cR_SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cR_SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.cR_SplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.cR_SplitContainer1.Name = "cR_SplitContainer1";
            this.cR_SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // cR_SplitContainer1.Panel1
            // 
            this.cR_SplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.cR_SplitContainer1.Panel1.Controls.Add(this.cR_Subtitulos1);
            // 
            // cR_SplitContainer1.Panel2
            // 
            this.cR_SplitContainer1.Panel2.Controls.Add(this.panel1);
            this.cR_SplitContainer1.Size = new System.Drawing.Size(928, 450);
            this.cR_SplitContainer1.SplitterDistance = 80;
            this.cR_SplitContainer1.TabIndex = 0;
            // 
            // cR_Subtitulos1
            // 
            this.cR_Subtitulos1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cR_Subtitulos1.AutoSize = true;
            this.cR_Subtitulos1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.cR_Subtitulos1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cR_Subtitulos1.ForeColor = System.Drawing.Color.White;
            this.cR_Subtitulos1.Location = new System.Drawing.Point(217, 23);
            this.cR_Subtitulos1.Name = "cR_Subtitulos1";
            this.cR_Subtitulos1.Size = new System.Drawing.Size(168, 31);
            this.cR_Subtitulos1.TabIndex = 0;
            this.cR_Subtitulos1.Text = "Ver Entradas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.cR_LabelDown2);
            this.panel1.Controls.Add(this.cR_LabelDown1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 366);
            this.panel1.TabIndex = 0;
            // 
            // dgvEntrys
            // 
            this.dgvEntrys.AllowUserToAddRows = false;
            this.dgvEntrys.AllowUserToDeleteRows = false;
            this.dgvEntrys.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvEntrys.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEntrys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntrys.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvEntrys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEntrys.EnableHeadersVisualStyles = false;
            this.dgvEntrys.Location = new System.Drawing.Point(0, 0);
            this.dgvEntrys.Name = "dgvEntrys";
            this.dgvEntrys.ReadOnly = true;
            this.dgvEntrys.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntrys.Size = new System.Drawing.Size(611, 312);
            this.dgvEntrys.TabIndex = 1;
            this.dgvEntrys.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cR_DataGriedView1_CellContentClick);
            // 
            // cR_DataGriedView1
            // 
            this.cR_DataGriedView1.AllowUserToAddRows = false;
            this.cR_DataGriedView1.AllowUserToDeleteRows = false;
            this.cR_DataGriedView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.cR_DataGriedView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.cR_DataGriedView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cR_DataGriedView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8});
            this.cR_DataGriedView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cR_DataGriedView1.EnableHeadersVisualStyles = false;
            this.cR_DataGriedView1.Location = new System.Drawing.Point(0, 0);
            this.cR_DataGriedView1.Name = "cR_DataGriedView1";
            this.cR_DataGriedView1.ReadOnly = true;
            this.cR_DataGriedView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cR_DataGriedView1.Size = new System.Drawing.Size(254, 354);
            this.cR_DataGriedView1.TabIndex = 2;
            // 
            // cR_LabelDown1
            // 
            this.cR_LabelDown1.AutoSize = true;
            this.cR_LabelDown1.Font = new System.Drawing.Font("Microsoft YaHei", 15F);
            this.cR_LabelDown1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.cR_LabelDown1.Location = new System.Drawing.Point(256, 21);
            this.cR_LabelDown1.Name = "cR_LabelDown1";
            this.cR_LabelDown1.Size = new System.Drawing.Size(94, 27);
            this.cR_LabelDown1.TabIndex = 3;
            this.cR_LabelDown1.Text = "Entradas";
            // 
            // cR_LabelDown2
            // 
            this.cR_LabelDown2.AutoSize = true;
            this.cR_LabelDown2.Font = new System.Drawing.Font("Microsoft YaHei", 15F);
            this.cR_LabelDown2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.cR_LabelDown2.Location = new System.Drawing.Point(763, 21);
            this.cR_LabelDown2.Name = "cR_LabelDown2";
            this.cR_LabelDown2.Size = new System.Drawing.Size(114, 27);
            this.cR_LabelDown2.TabIndex = 4;
            this.cR_LabelDown2.Text = "Accesorios";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tipo";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Marca";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Modelo";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Serial";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Falla";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Fecha y Hora";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Accesorios";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cR_DataGriedView1);
            this.panel2.Location = new System.Drawing.Point(671, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 354);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvEntrys);
            this.panel3.Location = new System.Drawing.Point(35, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(611, 312);
            this.panel3.TabIndex = 6;
            // 
            // VisualizarEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 450);
            this.Controls.Add(this.cR_SplitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VisualizarEntradas";
            this.Text = "Ver entradas de equipos";
            this.Load += new System.EventHandler(this.VisualizarEntradas_Load);
            this.cR_SplitContainer1.Panel1.ResumeLayout(false);
            this.cR_SplitContainer1.Panel1.PerformLayout();
            this.cR_SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cR_SplitContainer1)).EndInit();
            this.cR_SplitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cR_DataGriedView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CR_SplitContainer cR_SplitContainer1;
        private CR_Subtitulos cR_Subtitulos1;
        private System.Windows.Forms.Panel panel1;
        private CR_DataGriedView dgvEntrys;
        private CR_DataGriedView cR_DataGriedView1;
        private CR_LabelDown cR_LabelDown2;
        private CR_LabelDown cR_LabelDown1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}
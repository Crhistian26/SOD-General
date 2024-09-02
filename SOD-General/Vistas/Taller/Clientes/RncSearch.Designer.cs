namespace SOD_General.Vistas.Taller.Clientes
{
    partial class RncSearch
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
            this.cR_SplitContainer1 = new CR_SplitContainer();
            this.cR_Subtitulos1 = new CR_Subtitulos();
            this.cmbRnc = new Cr_ComboBox();
            this.cR_LabelDown2 = new CR_LabelDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvRncSearch = new CR_DataGriedView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbNmb = new Cr_ComboBox();
            this.cR_LabelDown1 = new CR_LabelDown();
            this.btnGuardar = new Diseños.Botones_Nuevos();
            ((System.ComponentModel.ISupportInitialize)(this.cR_SplitContainer1)).BeginInit();
            this.cR_SplitContainer1.Panel1.SuspendLayout();
            this.cR_SplitContainer1.Panel2.SuspendLayout();
            this.cR_SplitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRncSearch)).BeginInit();
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
            this.cR_SplitContainer1.Panel2.Controls.Add(this.cmbRnc);
            this.cR_SplitContainer1.Panel2.Controls.Add(this.cR_LabelDown2);
            this.cR_SplitContainer1.Panel2.Controls.Add(this.panel1);
            this.cR_SplitContainer1.Panel2.Controls.Add(this.cmbNmb);
            this.cR_SplitContainer1.Panel2.Controls.Add(this.cR_LabelDown1);
            this.cR_SplitContainer1.Panel2.Controls.Add(this.btnGuardar);
            this.cR_SplitContainer1.Size = new System.Drawing.Size(800, 450);
            this.cR_SplitContainer1.SplitterDistance = 65;
            this.cR_SplitContainer1.TabIndex = 7;
            // 
            // cR_Subtitulos1
            // 
            this.cR_Subtitulos1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cR_Subtitulos1.AutoSize = true;
            this.cR_Subtitulos1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.cR_Subtitulos1.Font = new System.Drawing.Font("Microsoft YaHei", 14.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cR_Subtitulos1.ForeColor = System.Drawing.Color.White;
            this.cR_Subtitulos1.Location = new System.Drawing.Point(256, 20);
            this.cR_Subtitulos1.Name = "cR_Subtitulos1";
            this.cR_Subtitulos1.Size = new System.Drawing.Size(226, 27);
            this.cR_Subtitulos1.TabIndex = 1;
            this.cR_Subtitulos1.Text = "Buscar Entidad Social";
            this.cR_Subtitulos1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbRnc
            // 
            this.cmbRnc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbRnc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRnc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.cmbRnc.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cmbRnc.ForeColor = System.Drawing.Color.White;
            this.cmbRnc.FormattingEnabled = true;
            this.cmbRnc.Location = new System.Drawing.Point(272, 33);
            this.cmbRnc.Name = "cmbRnc";
            this.cmbRnc.Size = new System.Drawing.Size(188, 29);
            this.cmbRnc.TabIndex = 11;
            this.cmbRnc.SelectedIndexChanged += new System.EventHandler(this.cmbRnc_SelectedIndexChanged);
            // 
            // cR_LabelDown2
            // 
            this.cR_LabelDown2.AutoSize = true;
            this.cR_LabelDown2.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.cR_LabelDown2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.cR_LabelDown2.Location = new System.Drawing.Point(268, 10);
            this.cR_LabelDown2.Name = "cR_LabelDown2";
            this.cR_LabelDown2.Size = new System.Drawing.Size(91, 20);
            this.cR_LabelDown2.TabIndex = 10;
            this.cR_LabelDown2.Text = "RNC/Cedula";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvRncSearch);
            this.panel1.Location = new System.Drawing.Point(12, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 293);
            this.panel1.TabIndex = 9;
            // 
            // dgvRncSearch
            // 
            this.dgvRncSearch.AllowUserToAddRows = false;
            this.dgvRncSearch.AllowUserToDeleteRows = false;
            this.dgvRncSearch.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvRncSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRncSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRncSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvRncSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRncSearch.EnableHeadersVisualStyles = false;
            this.dgvRncSearch.Location = new System.Drawing.Point(0, 0);
            this.dgvRncSearch.Name = "dgvRncSearch";
            this.dgvRncSearch.ReadOnly = true;
            this.dgvRncSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRncSearch.Size = new System.Drawing.Size(766, 293);
            this.dgvRncSearch.TabIndex = 0;
            this.dgvRncSearch.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRncSearch_CellDoubleClick);
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Id";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "RNC/Cedula";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Direccion";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Telefono 1";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Telefono 2";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // cmbNmb
            // 
            this.cmbNmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbNmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbNmb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.cmbNmb.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cmbNmb.ForeColor = System.Drawing.Color.White;
            this.cmbNmb.FormattingEnabled = true;
            this.cmbNmb.Location = new System.Drawing.Point(12, 33);
            this.cmbNmb.Name = "cmbNmb";
            this.cmbNmb.Size = new System.Drawing.Size(188, 29);
            this.cmbNmb.TabIndex = 8;
            this.cmbNmb.SelectedIndexChanged += new System.EventHandler(this.cmbNmb_SelectedIndexChanged);
            // 
            // cR_LabelDown1
            // 
            this.cR_LabelDown1.AutoSize = true;
            this.cR_LabelDown1.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.cR_LabelDown1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.cR_LabelDown1.Location = new System.Drawing.Point(8, 10);
            this.cR_LabelDown1.Name = "cR_LabelDown1";
            this.cR_LabelDown1.Size = new System.Drawing.Size(64, 20);
            this.cR_LabelDown1.TabIndex = 7;
            this.cR_LabelDown1.Text = "Nombre";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(118)))));
            this.btnGuardar.BorderColor = System.Drawing.Color.Teal;
            this.btnGuardar.BorderRadius = 40;
            this.btnGuardar.BorderSize = 0;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(637, 23);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(141, 39);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // RncSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cR_SplitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "RncSearch";
            this.Text = "RncSearch";
            this.cR_SplitContainer1.Panel1.ResumeLayout(false);
            this.cR_SplitContainer1.Panel1.PerformLayout();
            this.cR_SplitContainer1.Panel2.ResumeLayout(false);
            this.cR_SplitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cR_SplitContainer1)).EndInit();
            this.cR_SplitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRncSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_SplitContainer cR_SplitContainer1;
        private CR_Subtitulos cR_Subtitulos1;
        private Cr_ComboBox cmbRnc;
        private CR_LabelDown cR_LabelDown2;
        private System.Windows.Forms.Panel panel1;
        private CR_DataGriedView dgvRncSearch;
        private Cr_ComboBox cmbNmb;
        private CR_LabelDown cR_LabelDown1;
        private Diseños.Botones_Nuevos btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
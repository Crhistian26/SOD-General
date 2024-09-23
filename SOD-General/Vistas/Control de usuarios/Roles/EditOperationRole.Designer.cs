namespace SOD_General.Vistas.Control_de_usuarios.Operaciones
{
    partial class EditOperationRole
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cR_SplitContainer1 = new CR_SplitContainer();
            this.cR_Subtitulos1 = new CR_Subtitulos();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cr_ComboBox1 = new Cr_ComboBox();
            this.cR_LabelDown1 = new CR_LabelDown();
            this.cR_DataGriedViewNormal2 = new CR_DataGriedViewNormal();
            this.botones_Nuevos1 = new Diseños.Botones_Nuevos();
            this.cR_LabelDown2 = new CR_LabelDown();
            this.cR_LabelDown3 = new CR_LabelDown();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cR_DataGriedViewNormal1 = new CR_DataGriedViewNormal();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cR_SplitContainer1)).BeginInit();
            this.cR_SplitContainer1.Panel1.SuspendLayout();
            this.cR_SplitContainer1.Panel2.SuspendLayout();
            this.cR_SplitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cR_DataGriedViewNormal2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cR_DataGriedViewNormal1)).BeginInit();
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
            this.cR_SplitContainer1.Panel1.Resize += new System.EventHandler(this.cR_SplitContainer1_Panel1_Resize);
            // 
            // cR_SplitContainer1.Panel2
            // 
            this.cR_SplitContainer1.Panel2.Controls.Add(this.panel1);
            this.cR_SplitContainer1.Size = new System.Drawing.Size(1068, 492);
            this.cR_SplitContainer1.SplitterDistance = 54;
            this.cR_SplitContainer1.TabIndex = 1;
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
            this.cR_Subtitulos1.Location = new System.Drawing.Point(424, 9);
            this.cR_Subtitulos1.Name = "cR_Subtitulos1";
            this.cR_Subtitulos1.Size = new System.Drawing.Size(293, 31);
            this.cR_Subtitulos1.TabIndex = 0;
            this.cR_Subtitulos1.Text = "Operaciones asignadas";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cR_DataGriedViewNormal1);
            this.panel1.Controls.Add(this.cR_LabelDown3);
            this.panel1.Controls.Add(this.cR_LabelDown2);
            this.panel1.Controls.Add(this.botones_Nuevos1);
            this.panel1.Controls.Add(this.cR_DataGriedViewNormal2);
            this.panel1.Controls.Add(this.cR_LabelDown1);
            this.panel1.Controls.Add(this.cr_ComboBox1);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 419);
            this.panel1.TabIndex = 0;
            // 
            // cr_ComboBox1
            // 
            this.cr_ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cr_ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cr_ComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.cr_ComboBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cr_ComboBox1.ForeColor = System.Drawing.Color.White;
            this.cr_ComboBox1.FormattingEnabled = true;
            this.cr_ComboBox1.Location = new System.Drawing.Point(211, 35);
            this.cr_ComboBox1.Name = "cr_ComboBox1";
            this.cr_ComboBox1.Size = new System.Drawing.Size(174, 29);
            this.cr_ComboBox1.TabIndex = 0;
            // 
            // cR_LabelDown1
            // 
            this.cR_LabelDown1.AutoSize = true;
            this.cR_LabelDown1.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.cR_LabelDown1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.cR_LabelDown1.Location = new System.Drawing.Point(217, 12);
            this.cR_LabelDown1.Name = "cR_LabelDown1";
            this.cR_LabelDown1.Size = new System.Drawing.Size(131, 20);
            this.cR_LabelDown1.TabIndex = 1;
            this.cR_LabelDown1.Text = "Filtrar por modulo";
            // 
            // cR_DataGriedViewNormal2
            // 
            this.cR_DataGriedViewNormal2.AllowUserToAddRows = false;
            this.cR_DataGriedViewNormal2.AllowUserToDeleteRows = false;
            this.cR_DataGriedViewNormal2.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.cR_DataGriedViewNormal2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.cR_DataGriedViewNormal2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cR_DataGriedViewNormal2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Operacion,
            this.Modulo});
            this.cR_DataGriedViewNormal2.EnableHeadersVisualStyles = false;
            this.cR_DataGriedViewNormal2.Location = new System.Drawing.Point(565, 70);
            this.cR_DataGriedViewNormal2.Name = "cR_DataGriedViewNormal2";
            this.cR_DataGriedViewNormal2.ReadOnly = true;
            this.cR_DataGriedViewNormal2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cR_DataGriedViewNormal2.Size = new System.Drawing.Size(459, 285);
            this.cR_DataGriedViewNormal2.TabIndex = 3;
            // 
            // botones_Nuevos1
            // 
            this.botones_Nuevos1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(118)))));
            this.botones_Nuevos1.BorderColor = System.Drawing.Color.Teal;
            this.botones_Nuevos1.BorderRadius = 40;
            this.botones_Nuevos1.BorderSize = 0;
            this.botones_Nuevos1.FlatAppearance.BorderSize = 0;
            this.botones_Nuevos1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botones_Nuevos1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.botones_Nuevos1.ForeColor = System.Drawing.Color.White;
            this.botones_Nuevos1.Location = new System.Drawing.Point(845, 361);
            this.botones_Nuevos1.Name = "botones_Nuevos1";
            this.botones_Nuevos1.Size = new System.Drawing.Size(179, 40);
            this.botones_Nuevos1.TabIndex = 4;
            this.botones_Nuevos1.Text = "Guardar cambios";
            this.botones_Nuevos1.UseVisualStyleBackColor = false;
            // 
            // cR_LabelDown2
            // 
            this.cR_LabelDown2.AutoSize = true;
            this.cR_LabelDown2.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.cR_LabelDown2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.cR_LabelDown2.Location = new System.Drawing.Point(15, 40);
            this.cR_LabelDown2.Name = "cR_LabelDown2";
            this.cR_LabelDown2.Size = new System.Drawing.Size(160, 20);
            this.cR_LabelDown2.TabIndex = 5;
            this.cR_LabelDown2.Text = "Todas las operaciones:";
            // 
            // cR_LabelDown3
            // 
            this.cR_LabelDown3.AutoSize = true;
            this.cR_LabelDown3.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.cR_LabelDown3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.cR_LabelDown3.Location = new System.Drawing.Point(604, 47);
            this.cR_LabelDown3.Name = "cR_LabelDown3";
            this.cR_LabelDown3.Size = new System.Drawing.Size(143, 20);
            this.cR_LabelDown3.TabIndex = 6;
            this.cR_LabelDown3.Text = "Operaciones del rol:";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Operacion
            // 
            this.Operacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Operacion.HeaderText = "Operacion";
            this.Operacion.Name = "Operacion";
            this.Operacion.ReadOnly = true;
            // 
            // Modulo
            // 
            this.Modulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Modulo.HeaderText = "Modulo";
            this.Modulo.Name = "Modulo";
            this.Modulo.ReadOnly = true;
            this.Modulo.Width = 88;
            // 
            // cR_DataGriedViewNormal1
            // 
            this.cR_DataGriedViewNormal1.AllowUserToAddRows = false;
            this.cR_DataGriedViewNormal1.AllowUserToDeleteRows = false;
            this.cR_DataGriedViewNormal1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.cR_DataGriedViewNormal1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.cR_DataGriedViewNormal1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cR_DataGriedViewNormal1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.cR_DataGriedViewNormal1.EnableHeadersVisualStyles = false;
            this.cR_DataGriedViewNormal1.Location = new System.Drawing.Point(22, 70);
            this.cR_DataGriedViewNormal1.Name = "cR_DataGriedViewNormal1";
            this.cR_DataGriedViewNormal1.ReadOnly = true;
            this.cR_DataGriedViewNormal1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cR_DataGriedViewNormal1.Size = new System.Drawing.Size(506, 285);
            this.cR_DataGriedViewNormal1.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Operacion";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.HeaderText = "Modulo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 88;
            // 
            // VisualOperationsRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 492);
            this.Controls.Add(this.cR_SplitContainer1);
            this.Name = "VisualOperationsRole";
            this.Text = "VisualOperacionesRole";
            this.cR_SplitContainer1.Panel1.ResumeLayout(false);
            this.cR_SplitContainer1.Panel1.PerformLayout();
            this.cR_SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cR_SplitContainer1)).EndInit();
            this.cR_SplitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cR_DataGriedViewNormal2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cR_DataGriedViewNormal1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_SplitContainer cR_SplitContainer1;
        private CR_Subtitulos cR_Subtitulos1;
        private System.Windows.Forms.Panel panel1;
        private CR_LabelDown cR_LabelDown1;
        private Cr_ComboBox cr_ComboBox1;
        private CR_DataGriedViewNormal cR_DataGriedViewNormal1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private CR_LabelDown cR_LabelDown3;
        private CR_LabelDown cR_LabelDown2;
        private Diseños.Botones_Nuevos botones_Nuevos1;
        private CR_DataGriedViewNormal cR_DataGriedViewNormal2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modulo;
    }
}
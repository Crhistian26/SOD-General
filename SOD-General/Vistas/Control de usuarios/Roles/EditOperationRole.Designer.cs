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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cR_SplitContainer1 = new CR_SplitContainer();
            this.cR_Subtitulos1 = new CR_Subtitulos();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cR_DataGriedView1 = new CR_DataGriedViewNormal();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cR_LabelDown3 = new CR_LabelDown();
            this.cR_LabelDown2 = new CR_LabelDown();
            this.botones_Nuevos1 = new Diseños.Botones_Nuevos();
            this.cR_DataGriedView2 = new CR_DataGriedViewNormal();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cR_LabelDown1 = new CR_LabelDown();
            this.cr_ComboBox1 = new Cr_ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.cR_SplitContainer1)).BeginInit();
            this.cR_SplitContainer1.Panel1.SuspendLayout();
            this.cR_SplitContainer1.Panel2.SuspendLayout();
            this.cR_SplitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cR_DataGriedView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cR_DataGriedView2)).BeginInit();
            this.SuspendLayout();
            // 
            // cR_SplitContainer1
            // 
            this.cR_SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cR_SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.cR_SplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.cR_SplitContainer1.Margin = new System.Windows.Forms.Padding(4);
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
            this.cR_SplitContainer1.Size = new System.Drawing.Size(1424, 606);
            this.cR_SplitContainer1.SplitterDistance = 54;
            this.cR_SplitContainer1.SplitterWidth = 5;
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
            this.cR_Subtitulos1.Location = new System.Drawing.Point(565, 11);
            this.cR_Subtitulos1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cR_Subtitulos1.Name = "cR_Subtitulos1";
            this.cR_Subtitulos1.Size = new System.Drawing.Size(363, 40);
            this.cR_Subtitulos1.TabIndex = 0;
            this.cR_Subtitulos1.Text = "Operaciones asignadas";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cR_DataGriedView1);
            this.panel1.Controls.Add(this.cR_LabelDown3);
            this.panel1.Controls.Add(this.cR_LabelDown2);
            this.panel1.Controls.Add(this.botones_Nuevos1);
            this.panel1.Controls.Add(this.cR_DataGriedView2);
            this.panel1.Controls.Add(this.cR_LabelDown1);
            this.panel1.Controls.Add(this.cr_ComboBox1);
            this.panel1.Location = new System.Drawing.Point(16, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1392, 516);
            this.panel1.TabIndex = 0;
            // 
            // cR_DataGriedView1
            // 
            this.cR_DataGriedView1.AllowUserToAddRows = false;
            this.cR_DataGriedView1.AllowUserToDeleteRows = false;
            this.cR_DataGriedView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.cR_DataGriedView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.cR_DataGriedView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cR_DataGriedView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.cR_DataGriedView1.EnableHeadersVisualStyles = false;
            this.cR_DataGriedView1.Location = new System.Drawing.Point(29, 86);
            this.cR_DataGriedView1.Margin = new System.Windows.Forms.Padding(4);
            this.cR_DataGriedView1.Name = "cR_DataGriedView1";
            this.cR_DataGriedView1.ReadOnly = true;
            this.cR_DataGriedView1.RowHeadersWidth = 51;
            this.cR_DataGriedView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cR_DataGriedView1.Size = new System.Drawing.Size(675, 351);
            this.cR_DataGriedView1.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Operacion";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Modulo";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // cR_LabelDown3
            // 
            this.cR_LabelDown3.AutoSize = true;
            this.cR_LabelDown3.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.cR_LabelDown3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.cR_LabelDown3.Location = new System.Drawing.Point(805, 58);
            this.cR_LabelDown3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cR_LabelDown3.Name = "cR_LabelDown3";
            this.cR_LabelDown3.Size = new System.Drawing.Size(175, 23);
            this.cR_LabelDown3.TabIndex = 6;
            this.cR_LabelDown3.Text = "Operaciones del rol:";
            // 
            // cR_LabelDown2
            // 
            this.cR_LabelDown2.AutoSize = true;
            this.cR_LabelDown2.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.cR_LabelDown2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.cR_LabelDown2.Location = new System.Drawing.Point(20, 49);
            this.cR_LabelDown2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cR_LabelDown2.Name = "cR_LabelDown2";
            this.cR_LabelDown2.Size = new System.Drawing.Size(195, 23);
            this.cR_LabelDown2.TabIndex = 5;
            this.cR_LabelDown2.Text = "Todas las operaciones:";
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
            this.botones_Nuevos1.Location = new System.Drawing.Point(1127, 444);
            this.botones_Nuevos1.Margin = new System.Windows.Forms.Padding(4);
            this.botones_Nuevos1.Name = "botones_Nuevos1";
            this.botones_Nuevos1.Size = new System.Drawing.Size(239, 49);
            this.botones_Nuevos1.TabIndex = 4;
            this.botones_Nuevos1.Text = "Guardar cambios";
            this.botones_Nuevos1.UseVisualStyleBackColor = false;
            // 
            // cR_DataGriedView2
            // 
            this.cR_DataGriedView2.AllowUserToAddRows = false;
            this.cR_DataGriedView2.AllowUserToDeleteRows = false;
            this.cR_DataGriedView2.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.cR_DataGriedView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.cR_DataGriedView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cR_DataGriedView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Operacion,
            this.Modulo});
            this.cR_DataGriedView2.EnableHeadersVisualStyles = false;
            this.cR_DataGriedView2.Location = new System.Drawing.Point(753, 86);
            this.cR_DataGriedView2.Margin = new System.Windows.Forms.Padding(4);
            this.cR_DataGriedView2.Name = "cR_DataGriedView2";
            this.cR_DataGriedView2.ReadOnly = true;
            this.cR_DataGriedView2.RowHeadersWidth = 51;
            this.cR_DataGriedView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cR_DataGriedView2.Size = new System.Drawing.Size(612, 351);
            this.cR_DataGriedView2.TabIndex = 3;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Operacion
            // 
            this.Operacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Operacion.HeaderText = "Operacion";
            this.Operacion.MinimumWidth = 6;
            this.Operacion.Name = "Operacion";
            this.Operacion.ReadOnly = true;
            // 
            // Modulo
            // 
            this.Modulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Modulo.HeaderText = "Modulo";
            this.Modulo.MinimumWidth = 6;
            this.Modulo.Name = "Modulo";
            this.Modulo.ReadOnly = true;
            // 
            // cR_LabelDown1
            // 
            this.cR_LabelDown1.AutoSize = true;
            this.cR_LabelDown1.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.cR_LabelDown1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.cR_LabelDown1.Location = new System.Drawing.Point(289, 15);
            this.cR_LabelDown1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cR_LabelDown1.Name = "cR_LabelDown1";
            this.cR_LabelDown1.Size = new System.Drawing.Size(158, 23);
            this.cR_LabelDown1.TabIndex = 1;
            this.cR_LabelDown1.Text = "Filtrar por modulo";
            // 
            // cr_ComboBox1
            // 
            this.cr_ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cr_ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cr_ComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.cr_ComboBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cr_ComboBox1.ForeColor = System.Drawing.Color.White;
            this.cr_ComboBox1.FormattingEnabled = true;
            this.cr_ComboBox1.Location = new System.Drawing.Point(281, 43);
            this.cr_ComboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.cr_ComboBox1.Name = "cr_ComboBox1";
            this.cr_ComboBox1.Size = new System.Drawing.Size(231, 35);
            this.cr_ComboBox1.TabIndex = 0;
            this.cr_ComboBox1.SelectedIndexChanged += new System.EventHandler(this.cr_ComboBox1_SelectedIndexChanged);
            // 
            // EditOperationRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 606);
            this.Controls.Add(this.cR_SplitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditOperationRole";
            this.Text = "VisualOperacionesRole";
            this.Load += new System.EventHandler(this.EditOperationRole_Load);
            this.cR_SplitContainer1.Panel1.ResumeLayout(false);
            this.cR_SplitContainer1.Panel1.PerformLayout();
            this.cR_SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cR_SplitContainer1)).EndInit();
            this.cR_SplitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cR_DataGriedView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cR_DataGriedView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_SplitContainer cR_SplitContainer1;
        private CR_Subtitulos cR_Subtitulos1;
        private System.Windows.Forms.Panel panel1;
        private CR_LabelDown cR_LabelDown1;
        private Cr_ComboBox cr_ComboBox1;
        private CR_DataGriedViewNormal cR_DataGriedView1;
        private CR_LabelDown cR_LabelDown3;
        private CR_LabelDown cR_LabelDown2;
        private Diseños.Botones_Nuevos botones_Nuevos1;
        private CR_DataGriedViewNormal cR_DataGriedView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modulo;
    }
}
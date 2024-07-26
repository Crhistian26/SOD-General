namespace SOD_General.Vistas.Taller.Controles_de_Equipo
{
    partial class VisualizarEquiposControl
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
            this.cR_SplitContainer1 = new CR_SplitContainer();
            this.cR_Subtitulos1 = new CR_Subtitulos();
            this.cR_DataGriedView1 = new CR_DataGriedView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cR_LabelUp2 = new CR_LabelUp();
            this.cR_LabelUp1 = new CR_LabelUp();
            this.cR_DateTimePicker2 = new CR_DateTimePicker();
            this.cR_DateTimePicker1 = new CR_DateTimePicker();
            this.cr_Textbox1 = new Cr_Textbox();
            this.cR_LabelUp3 = new CR_LabelUp();
            ((System.ComponentModel.ISupportInitialize)(this.cR_SplitContainer1)).BeginInit();
            this.cR_SplitContainer1.Panel1.SuspendLayout();
            this.cR_SplitContainer1.Panel2.SuspendLayout();
            this.cR_SplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cR_DataGriedView1)).BeginInit();
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
            this.cR_SplitContainer1.Panel1.Controls.Add(this.cR_LabelUp3);
            this.cR_SplitContainer1.Panel1.Controls.Add(this.cr_Textbox1);
            this.cR_SplitContainer1.Panel1.Controls.Add(this.cR_LabelUp2);
            this.cR_SplitContainer1.Panel1.Controls.Add(this.cR_LabelUp1);
            this.cR_SplitContainer1.Panel1.Controls.Add(this.cR_DateTimePicker2);
            this.cR_SplitContainer1.Panel1.Controls.Add(this.cR_DateTimePicker1);
            this.cR_SplitContainer1.Panel1.Controls.Add(this.cR_Subtitulos1);
            // 
            // cR_SplitContainer1.Panel2
            // 
            this.cR_SplitContainer1.Panel2.Controls.Add(this.cR_DataGriedView1);
            this.cR_SplitContainer1.Size = new System.Drawing.Size(944, 450);
            this.cR_SplitContainer1.SplitterDistance = 96;
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
            this.cR_Subtitulos1.Location = new System.Drawing.Point(259, 3);
            this.cR_Subtitulos1.Name = "cR_Subtitulos1";
            this.cR_Subtitulos1.Size = new System.Drawing.Size(403, 31);
            this.cR_Subtitulos1.TabIndex = 0;
            this.cR_Subtitulos1.Text = "Equipos con controles aplicados";
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
            this.Column8,
            this.Column1,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column9});
            this.cR_DataGriedView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cR_DataGriedView1.EnableHeadersVisualStyles = false;
            this.cR_DataGriedView1.Location = new System.Drawing.Point(0, 0);
            this.cR_DataGriedView1.Name = "cR_DataGriedView1";
            this.cR_DataGriedView1.ReadOnly = true;
            this.cR_DataGriedView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cR_DataGriedView1.Size = new System.Drawing.Size(944, 350);
            this.cR_DataGriedView1.TabIndex = 3;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "# Orden";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Equipo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Serial";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Fallo";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Material/Servicio";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Tecnico";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Editar";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // cR_LabelUp2
            // 
            this.cR_LabelUp2.AutoSize = true;
            this.cR_LabelUp2.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.cR_LabelUp2.ForeColor = System.Drawing.Color.White;
            this.cR_LabelUp2.Location = new System.Drawing.Point(640, 69);
            this.cR_LabelUp2.Name = "cR_LabelUp2";
            this.cR_LabelUp2.Size = new System.Drawing.Size(47, 20);
            this.cR_LabelUp2.TabIndex = 42;
            this.cR_LabelUp2.Text = "Hasta";
            // 
            // cR_LabelUp1
            // 
            this.cR_LabelUp1.AutoSize = true;
            this.cR_LabelUp1.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.cR_LabelUp1.ForeColor = System.Drawing.Color.White;
            this.cR_LabelUp1.Location = new System.Drawing.Point(640, 39);
            this.cR_LabelUp1.Name = "cR_LabelUp1";
            this.cR_LabelUp1.Size = new System.Drawing.Size(51, 20);
            this.cR_LabelUp1.TabIndex = 41;
            this.cR_LabelUp1.Text = "Desde";
            // 
            // cR_DateTimePicker2
            // 
            this.cR_DateTimePicker2.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 11F);
            this.cR_DateTimePicker2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.cR_DateTimePicker2.Location = new System.Drawing.Point(693, 39);
            this.cR_DateTimePicker2.Name = "cR_DateTimePicker2";
            this.cR_DateTimePicker2.Size = new System.Drawing.Size(248, 24);
            this.cR_DateTimePicker2.TabIndex = 40;
            // 
            // cR_DateTimePicker1
            // 
            this.cR_DateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 11F);
            this.cR_DateTimePicker1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.cR_DateTimePicker1.Location = new System.Drawing.Point(693, 69);
            this.cR_DateTimePicker1.Name = "cR_DateTimePicker1";
            this.cR_DateTimePicker1.Size = new System.Drawing.Size(248, 24);
            this.cR_DateTimePicker1.TabIndex = 39;
            // 
            // cr_Textbox1
            // 
            this.cr_Textbox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cr_Textbox1.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.cr_Textbox1.Location = new System.Drawing.Point(82, 59);
            this.cr_Textbox1.Name = "cr_Textbox1";
            this.cr_Textbox1.Size = new System.Drawing.Size(100, 25);
            this.cr_Textbox1.TabIndex = 49;
            // 
            // cR_LabelUp3
            // 
            this.cR_LabelUp3.AutoSize = true;
            this.cR_LabelUp3.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.cR_LabelUp3.ForeColor = System.Drawing.Color.White;
            this.cR_LabelUp3.Location = new System.Drawing.Point(12, 59);
            this.cR_LabelUp3.Name = "cR_LabelUp3";
            this.cR_LabelUp3.Size = new System.Drawing.Size(64, 20);
            this.cR_LabelUp3.TabIndex = 50;
            this.cR_LabelUp3.Text = "# Orden";
            // 
            // VisualizarEquiposControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 450);
            this.Controls.Add(this.cR_SplitContainer1);
            this.Name = "VisualizarEquiposControl";
            this.Text = "VisualizarEquiposControl";
            this.cR_SplitContainer1.Panel1.ResumeLayout(false);
            this.cR_SplitContainer1.Panel1.PerformLayout();
            this.cR_SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cR_SplitContainer1)).EndInit();
            this.cR_SplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cR_DataGriedView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_SplitContainer cR_SplitContainer1;
        private CR_Subtitulos cR_Subtitulos1;
        private CR_DataGriedView cR_DataGriedView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewButtonColumn Column9;
        private CR_LabelUp cR_LabelUp3;
        private Cr_Textbox cr_Textbox1;
        private CR_LabelUp cR_LabelUp2;
        private CR_LabelUp cR_LabelUp1;
        private CR_DateTimePicker cR_DateTimePicker2;
        private CR_DateTimePicker cR_DateTimePicker1;
    }
}
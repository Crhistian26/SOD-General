namespace SOD_General.Vistas.Recursos_Humanos.Motivos
{
    partial class Visual_Motivos
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
            this.botones_Nuevos1 = new Diseños.Botones_Nuevos();
            this.cR_DataGriedView1 = new CR_DataGriedView();
            this.Motivos_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motivos_Reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motivos_Extent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motivos_Limit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motivos_Each = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.cR_SplitContainer1.Panel1.Controls.Add(this.botones_Nuevos1);
            this.cR_SplitContainer1.Panel1.Controls.Add(this.cR_Subtitulos1);
            // 
            // cR_SplitContainer1.Panel2
            // 
            this.cR_SplitContainer1.Panel2.Controls.Add(this.cR_DataGriedView1);
            this.cR_SplitContainer1.Size = new System.Drawing.Size(720, 470);
            this.cR_SplitContainer1.SplitterDistance = 110;
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
            this.cR_Subtitulos1.Location = new System.Drawing.Point(232, 9);
            this.cR_Subtitulos1.Name = "cR_Subtitulos1";
            this.cR_Subtitulos1.Size = new System.Drawing.Size(299, 31);
            this.cR_Subtitulos1.TabIndex = 0;
            this.cR_Subtitulos1.Text = "Motivos de inasistencia";
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
            this.botones_Nuevos1.Location = new System.Drawing.Point(308, 53);
            this.botones_Nuevos1.Name = "botones_Nuevos1";
            this.botones_Nuevos1.Size = new System.Drawing.Size(150, 40);
            this.botones_Nuevos1.TabIndex = 1;
            this.botones_Nuevos1.Text = "Agregar";
            this.botones_Nuevos1.UseVisualStyleBackColor = false;
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
            this.Motivos_Id,
            this.Motivos_Reason,
            this.Motivos_Extent,
            this.Motivos_Limit,
            this.Motivos_Each});
            this.cR_DataGriedView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cR_DataGriedView1.EnableHeadersVisualStyles = false;
            this.cR_DataGriedView1.Location = new System.Drawing.Point(0, 0);
            this.cR_DataGriedView1.Name = "cR_DataGriedView1";
            this.cR_DataGriedView1.ReadOnly = true;
            this.cR_DataGriedView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cR_DataGriedView1.Size = new System.Drawing.Size(720, 356);
            this.cR_DataGriedView1.TabIndex = 0;
            // 
            // Motivos_Id
            // 
            this.Motivos_Id.HeaderText = "Id";
            this.Motivos_Id.Name = "Motivos_Id";
            this.Motivos_Id.ReadOnly = true;
            this.Motivos_Id.Visible = false;
            // 
            // Motivos_Reason
            // 
            this.Motivos_Reason.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Motivos_Reason.HeaderText = "Motivo";
            this.Motivos_Reason.Name = "Motivos_Reason";
            this.Motivos_Reason.ReadOnly = true;
            // 
            // Motivos_Extent
            // 
            this.Motivos_Extent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Motivos_Extent.HeaderText = "Medida";
            this.Motivos_Extent.Name = "Motivos_Extent";
            this.Motivos_Extent.ReadOnly = true;
            // 
            // Motivos_Limit
            // 
            this.Motivos_Limit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Motivos_Limit.HeaderText = "Limite";
            this.Motivos_Limit.Name = "Motivos_Limit";
            this.Motivos_Limit.ReadOnly = true;
            // 
            // Motivos_Each
            // 
            this.Motivos_Each.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Motivos_Each.HeaderText = "Cada tanto";
            this.Motivos_Each.Name = "Motivos_Each";
            this.Motivos_Each.ReadOnly = true;
            // 
            // Visual_Motivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 470);
            this.Controls.Add(this.cR_SplitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(720, 470);
            this.Name = "Visual_Motivos";
            this.Text = "Visual_Motivos";
            this.Load += new System.EventHandler(this.Visual_Motivos_Load);
            this.Resize += new System.EventHandler(this.Visual_Motivos_Resize);
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
        private Diseños.Botones_Nuevos botones_Nuevos1;
        private CR_Subtitulos cR_Subtitulos1;
        private CR_DataGriedView cR_DataGriedView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motivos_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motivos_Reason;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motivos_Extent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motivos_Limit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motivos_Each;
    }
}
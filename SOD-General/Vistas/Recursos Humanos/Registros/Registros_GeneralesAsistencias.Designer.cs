namespace SOD_General.Vistas.Recursos_Humanos.Registros
{
    partial class Registros_GeneralesAsistencias
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
            this.botones_Nuevos1 = new Diseños.Botones_Nuevos();
            this.cR_DateTimePicker1 = new CR_DateTimePicker();
            this.cR_Subtitulos1 = new CR_Subtitulos();
            this.cR_DataGriedView2 = new CR_DataGriedView();
            this.Asistencias_RecordId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asistencias_Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asitencias_Entry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inicio_Receso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fin_Receso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asistencias_Exit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asistencias_Hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cR_SplitContainer1)).BeginInit();
            this.cR_SplitContainer1.Panel1.SuspendLayout();
            this.cR_SplitContainer1.Panel2.SuspendLayout();
            this.cR_SplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cR_DataGriedView2)).BeginInit();
            this.SuspendLayout();
            // 
            // cR_SplitContainer1
            // 
            this.cR_SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cR_SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.cR_SplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.cR_SplitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cR_SplitContainer1.Name = "cR_SplitContainer1";
            this.cR_SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // cR_SplitContainer1.Panel1
            // 
            this.cR_SplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.cR_SplitContainer1.Panel1.Controls.Add(this.botones_Nuevos1);
            this.cR_SplitContainer1.Panel1.Controls.Add(this.cR_DateTimePicker1);
            this.cR_SplitContainer1.Panel1.Controls.Add(this.cR_Subtitulos1);
            // 
            // cR_SplitContainer1.Panel2
            // 
            this.cR_SplitContainer1.Panel2.Controls.Add(this.cR_DataGriedView2);
            this.cR_SplitContainer1.Size = new System.Drawing.Size(1067, 578);
            this.cR_SplitContainer1.SplitterDistance = 136;
            this.cR_SplitContainer1.SplitterWidth = 5;
            this.cR_SplitContainer1.TabIndex = 0;
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
            this.botones_Nuevos1.Location = new System.Drawing.Point(16, 15);
            this.botones_Nuevos1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botones_Nuevos1.Name = "botones_Nuevos1";
            this.botones_Nuevos1.Size = new System.Drawing.Size(235, 49);
            this.botones_Nuevos1.TabIndex = 2;
            this.botones_Nuevos1.Text = "Agregar asistencias";
            this.botones_Nuevos1.UseVisualStyleBackColor = false;
            this.botones_Nuevos1.Click += new System.EventHandler(this.botones_Nuevos1_Click);
            // 
            // cR_DateTimePicker1
            // 
            this.cR_DateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 11F);
            this.cR_DateTimePicker1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.cR_DateTimePicker1.Location = new System.Drawing.Point(352, 81);
            this.cR_DateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cR_DateTimePicker1.Name = "cR_DateTimePicker1";
            this.cR_DateTimePicker1.Size = new System.Drawing.Size(352, 29);
            this.cR_DateTimePicker1.TabIndex = 1;
            this.cR_DateTimePicker1.ValueChanged += new System.EventHandler(this.cR_DateTimePicker1_ValueChanged);
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
            this.cR_Subtitulos1.Location = new System.Drawing.Point(332, 11);
            this.cR_Subtitulos1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cR_Subtitulos1.Name = "cR_Subtitulos1";
            this.cR_Subtitulos1.Size = new System.Drawing.Size(360, 40);
            this.cR_Subtitulos1.TabIndex = 0;
            this.cR_Subtitulos1.Text = "Registro de asistencias";
            // 
            // cR_DataGriedView2
            // 
            this.cR_DataGriedView2.AllowUserToAddRows = false;
            this.cR_DataGriedView2.AllowUserToDeleteRows = false;
            this.cR_DataGriedView2.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.cR_DataGriedView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.cR_DataGriedView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cR_DataGriedView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Asistencias_RecordId,
            this.Asistencias_Employee,
            this.Asitencias_Entry,
            this.Inicio_Receso,
            this.Fin_Receso,
            this.Asistencias_Exit,
            this.Asistencias_Hours});
            this.cR_DataGriedView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cR_DataGriedView2.EnableHeadersVisualStyles = false;
            this.cR_DataGriedView2.Location = new System.Drawing.Point(0, 0);
            this.cR_DataGriedView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cR_DataGriedView2.Name = "cR_DataGriedView2";
            this.cR_DataGriedView2.ReadOnly = true;
            this.cR_DataGriedView2.RowHeadersWidth = 51;
            this.cR_DataGriedView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cR_DataGriedView2.Size = new System.Drawing.Size(1067, 437);
            this.cR_DataGriedView2.TabIndex = 3;
            this.cR_DataGriedView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cR_DataGriedView2_CellDoubleClick);
            // 
            // Asistencias_RecordId
            // 
            this.Asistencias_RecordId.HeaderText = "Id";
            this.Asistencias_RecordId.MinimumWidth = 6;
            this.Asistencias_RecordId.Name = "Asistencias_RecordId";
            this.Asistencias_RecordId.ReadOnly = true;
            this.Asistencias_RecordId.Visible = false;
            this.Asistencias_RecordId.Width = 125;
            // 
            // Asistencias_Employee
            // 
            this.Asistencias_Employee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Asistencias_Employee.HeaderText = "Empleado";
            this.Asistencias_Employee.MinimumWidth = 6;
            this.Asistencias_Employee.Name = "Asistencias_Employee";
            this.Asistencias_Employee.ReadOnly = true;
            // 
            // Asitencias_Entry
            // 
            this.Asitencias_Entry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Asitencias_Entry.HeaderText = "Entrada";
            this.Asitencias_Entry.MinimumWidth = 6;
            this.Asitencias_Entry.Name = "Asitencias_Entry";
            this.Asitencias_Entry.ReadOnly = true;
            // 
            // Inicio_Receso
            // 
            this.Inicio_Receso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Inicio_Receso.HeaderText = "Inicio de almuerzo";
            this.Inicio_Receso.MinimumWidth = 6;
            this.Inicio_Receso.Name = "Inicio_Receso";
            this.Inicio_Receso.ReadOnly = true;
            // 
            // Fin_Receso
            // 
            this.Fin_Receso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fin_Receso.HeaderText = "Fin de almuerzo";
            this.Fin_Receso.MinimumWidth = 6;
            this.Fin_Receso.Name = "Fin_Receso";
            this.Fin_Receso.ReadOnly = true;
            // 
            // Asistencias_Exit
            // 
            this.Asistencias_Exit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Asistencias_Exit.HeaderText = "Salida";
            this.Asistencias_Exit.MinimumWidth = 6;
            this.Asistencias_Exit.Name = "Asistencias_Exit";
            this.Asistencias_Exit.ReadOnly = true;
            // 
            // Asistencias_Hours
            // 
            this.Asistencias_Hours.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Asistencias_Hours.HeaderText = "Horas laborales";
            this.Asistencias_Hours.MinimumWidth = 6;
            this.Asistencias_Hours.Name = "Asistencias_Hours";
            this.Asistencias_Hours.ReadOnly = true;
            // 
            // Registros_GeneralesAsistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 578);
            this.Controls.Add(this.cR_SplitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(960, 578);
            this.Name = "Registros_GeneralesAsistencias";
            this.Text = "Registro_Asistencias";
            this.Load += new System.EventHandler(this.Registros_GeneralesAsistencias_Load);
            this.Resize += new System.EventHandler(this.Registros_GeneralesAsistencias_Resize);
            this.cR_SplitContainer1.Panel1.ResumeLayout(false);
            this.cR_SplitContainer1.Panel1.PerformLayout();
            this.cR_SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cR_SplitContainer1)).EndInit();
            this.cR_SplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cR_DataGriedView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_SplitContainer cR_SplitContainer1;
        private CR_Subtitulos cR_Subtitulos1;
        private CR_DataGriedView cR_DataGriedView2;
        private Diseños.Botones_Nuevos botones_Nuevos1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asistencias_RecordId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asistencias_Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asitencias_Entry;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inicio_Receso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fin_Receso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asistencias_Exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asistencias_Hours;
        public CR_DateTimePicker cR_DateTimePicker1;
    }
}
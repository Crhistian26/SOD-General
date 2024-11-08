namespace SOD_General.Vistas.Control_de_usuarios.Usuarios
{
    partial class Visual_Usuarios
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
            this.cr_ComboBox2 = new Cr_ComboBox();
            this.cR_LabelUp2 = new CR_LabelUp();
            this.cR_Subtitulos1 = new CR_Subtitulos();
            this.cR_DataGriedView1 = new CR_DataGriedView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botones_Nuevos1 = new Diseños.Botones_Nuevos();
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
            this.cR_SplitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.cR_SplitContainer1.Name = "cR_SplitContainer1";
            this.cR_SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // cR_SplitContainer1.Panel1
            // 
            this.cR_SplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.cR_SplitContainer1.Panel1.Controls.Add(this.botones_Nuevos1);
            this.cR_SplitContainer1.Panel1.Controls.Add(this.cr_ComboBox2);
            this.cR_SplitContainer1.Panel1.Controls.Add(this.cR_LabelUp2);
            this.cR_SplitContainer1.Panel1.Controls.Add(this.cR_Subtitulos1);
            // 
            // cR_SplitContainer1.Panel2
            // 
            this.cR_SplitContainer1.Panel2.Controls.Add(this.cR_DataGriedView1);
            this.cR_SplitContainer1.Size = new System.Drawing.Size(1067, 578);
            this.cR_SplitContainer1.SplitterDistance = 162;
            this.cR_SplitContainer1.SplitterWidth = 5;
            this.cR_SplitContainer1.TabIndex = 0;
            // 
            // cr_ComboBox2
            // 
            this.cr_ComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cr_ComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cr_ComboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cr_ComboBox2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cr_ComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.cr_ComboBox2.FormattingEnabled = true;
            this.cr_ComboBox2.Location = new System.Drawing.Point(13, 113);
            this.cr_ComboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.cr_ComboBox2.Name = "cr_ComboBox2";
            this.cr_ComboBox2.Size = new System.Drawing.Size(229, 35);
            this.cr_ComboBox2.TabIndex = 4;
            this.cr_ComboBox2.SelectedIndexChanged += new System.EventHandler(this.cr_ComboBox2_SelectedIndexChanged);
            // 
            // cR_LabelUp2
            // 
            this.cR_LabelUp2.AutoSize = true;
            this.cR_LabelUp2.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.cR_LabelUp2.ForeColor = System.Drawing.Color.White;
            this.cR_LabelUp2.Location = new System.Drawing.Point(11, 84);
            this.cR_LabelUp2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cR_LabelUp2.Name = "cR_LabelUp2";
            this.cR_LabelUp2.Size = new System.Drawing.Size(37, 23);
            this.cR_LabelUp2.TabIndex = 3;
            this.cR_LabelUp2.Text = "Rol";
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
            this.cR_Subtitulos1.Location = new System.Drawing.Point(459, 9);
            this.cR_Subtitulos1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cR_Subtitulos1.Name = "cR_Subtitulos1";
            this.cR_Subtitulos1.Size = new System.Drawing.Size(148, 40);
            this.cR_Subtitulos1.TabIndex = 2;
            this.cR_Subtitulos1.Text = "Usuarios";
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
            this.Id,
            this.Empleado,
            this.Nombre_Usuario,
            this.Rol});
            this.cR_DataGriedView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cR_DataGriedView1.EnableHeadersVisualStyles = false;
            this.cR_DataGriedView1.Location = new System.Drawing.Point(0, 0);
            this.cR_DataGriedView1.Margin = new System.Windows.Forms.Padding(4);
            this.cR_DataGriedView1.Name = "cR_DataGriedView1";
            this.cR_DataGriedView1.ReadOnly = true;
            this.cR_DataGriedView1.RowHeadersWidth = 51;
            this.cR_DataGriedView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cR_DataGriedView1.Size = new System.Drawing.Size(1067, 411);
            this.cR_DataGriedView1.TabIndex = 0;
            this.cR_DataGriedView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cR_DataGriedView1_CellDoubleClick);
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
            // Empleado
            // 
            this.Empleado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Empleado.HeaderText = "Empleado";
            this.Empleado.MinimumWidth = 6;
            this.Empleado.Name = "Empleado";
            this.Empleado.ReadOnly = true;
            // 
            // Nombre_Usuario
            // 
            this.Nombre_Usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre_Usuario.HeaderText = "Nombre de usuario";
            this.Nombre_Usuario.MinimumWidth = 6;
            this.Nombre_Usuario.Name = "Nombre_Usuario";
            this.Nombre_Usuario.ReadOnly = true;
            // 
            // Rol
            // 
            this.Rol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Rol.HeaderText = "Rol";
            this.Rol.MinimumWidth = 6;
            this.Rol.Name = "Rol";
            this.Rol.ReadOnly = true;
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
            this.botones_Nuevos1.Location = new System.Drawing.Point(13, 9);
            this.botones_Nuevos1.Margin = new System.Windows.Forms.Padding(4);
            this.botones_Nuevos1.Name = "botones_Nuevos1";
            this.botones_Nuevos1.Size = new System.Drawing.Size(239, 49);
            this.botones_Nuevos1.TabIndex = 6;
            this.botones_Nuevos1.Text = "Agregar usuario";
            this.botones_Nuevos1.UseVisualStyleBackColor = false;
            // 
            // Visual_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 578);
            this.Controls.Add(this.cR_SplitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1067, 578);
            this.Name = "Visual_Usuarios";
            this.Text = "Visual_Usuarios";
            this.Load += new System.EventHandler(this.Visual_Usuarios_Load);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private Cr_ComboBox cr_ComboBox2;
        private CR_LabelUp cR_LabelUp2;
        private Diseños.Botones_Nuevos botones_Nuevos1;
    }
}
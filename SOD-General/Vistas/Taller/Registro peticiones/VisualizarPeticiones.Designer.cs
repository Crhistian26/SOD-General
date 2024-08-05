namespace SOD_General.Vistas_Taller.Taller_Recepcion
{
    partial class VisualizarPeticiones
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
            this.Cliente = new CR_LabelUp();
            this.soD_ComboBox1 = new SOD_ComboBox();
            this.cR_LabelUp2 = new CR_LabelUp();
            this.cR_LabelUp1 = new CR_LabelUp();
            this.cR_DateTimePicker2 = new CR_DateTimePicker();
            this.cR_DateTimePicker1 = new CR_DateTimePicker();
            this.cR_DataGriedView1 = new CR_DataGriedView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peticiones_Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peticiones_Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peticiones_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peticiones_Details = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.cR_SplitContainer1.Panel1.Controls.Add(this.cR_Subtitulos1);
            this.cR_SplitContainer1.Panel1.Controls.Add(this.Cliente);
            this.cR_SplitContainer1.Panel1.Controls.Add(this.soD_ComboBox1);
            this.cR_SplitContainer1.Panel1.Controls.Add(this.cR_LabelUp2);
            this.cR_SplitContainer1.Panel1.Controls.Add(this.cR_LabelUp1);
            this.cR_SplitContainer1.Panel1.Controls.Add(this.cR_DateTimePicker2);
            this.cR_SplitContainer1.Panel1.Controls.Add(this.cR_DateTimePicker1);
            // 
            // cR_SplitContainer1.Panel2
            // 
            this.cR_SplitContainer1.Panel2.Controls.Add(this.cR_DataGriedView1);
            this.cR_SplitContainer1.Size = new System.Drawing.Size(927, 450);
            this.cR_SplitContainer1.SplitterDistance = 115;
            this.cR_SplitContainer1.SplitterWidth = 2;
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
            this.cR_Subtitulos1.Location = new System.Drawing.Point(12, 9);
            this.cR_Subtitulos1.Name = "cR_Subtitulos1";
            this.cR_Subtitulos1.Size = new System.Drawing.Size(311, 31);
            this.cR_Subtitulos1.TabIndex = 9;
            this.cR_Subtitulos1.Text = "Peticiones de reparacion";
            // 
            // Cliente
            // 
            this.Cliente.AutoSize = true;
            this.Cliente.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.Cliente.ForeColor = System.Drawing.Color.White;
            this.Cliente.Location = new System.Drawing.Point(13, 75);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(56, 20);
            this.Cliente.TabIndex = 8;
            this.Cliente.Text = "Cliente";
            // 
            // soD_ComboBox1
            // 
            this.soD_ComboBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.soD_ComboBox1.FormattingEnabled = true;
            this.soD_ComboBox1.Location = new System.Drawing.Point(75, 75);
            this.soD_ComboBox1.Name = "soD_ComboBox1";
            this.soD_ComboBox1.Size = new System.Drawing.Size(200, 27);
            this.soD_ComboBox1.TabIndex = 7;
            // 
            // cR_LabelUp2
            // 
            this.cR_LabelUp2.AutoSize = true;
            this.cR_LabelUp2.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.cR_LabelUp2.ForeColor = System.Drawing.Color.White;
            this.cR_LabelUp2.Location = new System.Drawing.Point(643, 53);
            this.cR_LabelUp2.Name = "cR_LabelUp2";
            this.cR_LabelUp2.Size = new System.Drawing.Size(47, 20);
            this.cR_LabelUp2.TabIndex = 6;
            this.cR_LabelUp2.Text = "Hasta";
            // 
            // cR_LabelUp1
            // 
            this.cR_LabelUp1.AutoSize = true;
            this.cR_LabelUp1.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.cR_LabelUp1.ForeColor = System.Drawing.Color.White;
            this.cR_LabelUp1.Location = new System.Drawing.Point(376, 52);
            this.cR_LabelUp1.Name = "cR_LabelUp1";
            this.cR_LabelUp1.Size = new System.Drawing.Size(51, 20);
            this.cR_LabelUp1.TabIndex = 5;
            this.cR_LabelUp1.Text = "Desde";
            // 
            // cR_DateTimePicker2
            // 
            this.cR_DateTimePicker2.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 11F);
            this.cR_DateTimePicker2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.cR_DateTimePicker2.Location = new System.Drawing.Point(376, 78);
            this.cR_DateTimePicker2.Name = "cR_DateTimePicker2";
            this.cR_DateTimePicker2.Size = new System.Drawing.Size(248, 24);
            this.cR_DateTimePicker2.TabIndex = 4;
            // 
            // cR_DateTimePicker1
            // 
            this.cR_DateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 11F);
            this.cR_DateTimePicker1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.cR_DateTimePicker1.Location = new System.Drawing.Point(647, 79);
            this.cR_DateTimePicker1.Name = "cR_DateTimePicker1";
            this.cR_DateTimePicker1.Size = new System.Drawing.Size(246, 24);
            this.cR_DateTimePicker1.TabIndex = 3;
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
            this.Column1,
            this.Peticiones_Client,
            this.Peticiones_Contact,
            this.Peticiones_Date,
            this.Peticiones_Details});
            this.cR_DataGriedView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cR_DataGriedView1.EnableHeadersVisualStyles = false;
            this.cR_DataGriedView1.Location = new System.Drawing.Point(0, 0);
            this.cR_DataGriedView1.Name = "cR_DataGriedView1";
            this.cR_DataGriedView1.ReadOnly = true;
            this.cR_DataGriedView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cR_DataGriedView1.Size = new System.Drawing.Size(927, 333);
            this.cR_DataGriedView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "# de orden";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Peticiones_Client
            // 
            this.Peticiones_Client.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Peticiones_Client.HeaderText = "Cliente";
            this.Peticiones_Client.Name = "Peticiones_Client";
            this.Peticiones_Client.ReadOnly = true;
            this.Peticiones_Client.Width = 81;
            // 
            // Peticiones_Contact
            // 
            this.Peticiones_Contact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Peticiones_Contact.HeaderText = "Contacto";
            this.Peticiones_Contact.Name = "Peticiones_Contact";
            this.Peticiones_Contact.ReadOnly = true;
            this.Peticiones_Contact.Width = 95;
            // 
            // Peticiones_Date
            // 
            this.Peticiones_Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Peticiones_Date.HeaderText = "Fecha";
            this.Peticiones_Date.Name = "Peticiones_Date";
            this.Peticiones_Date.ReadOnly = true;
            this.Peticiones_Date.Width = 73;
            // 
            // Peticiones_Details
            // 
            this.Peticiones_Details.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Peticiones_Details.HeaderText = "Detalles";
            this.Peticiones_Details.Name = "Peticiones_Details";
            this.Peticiones_Details.ReadOnly = true;
            // 
            // VisualizarPeticiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 450);
            this.Controls.Add(this.cR_SplitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VisualizarPeticiones";
            this.Text = "Ver Ordenes de entrada";
            this.Load += new System.EventHandler(this.VisualizarPeticiones_Load);
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
        private CR_DataGriedView cR_DataGriedView1;
        private CR_DateTimePicker cR_DateTimePicker2;
        private CR_DateTimePicker cR_DateTimePicker1;
        private CR_LabelUp Cliente;
        private SOD_ComboBox soD_ComboBox1;
        private CR_LabelUp cR_LabelUp2;
        private CR_LabelUp cR_LabelUp1;
        private CR_Subtitulos cR_Subtitulos1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peticiones_Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peticiones_Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peticiones_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peticiones_Details;
    }
}
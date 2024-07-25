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
            this.cR_SplitContainer1 = new CR_SplitContainer();
            this.soD_TextBox1 = new SOD_TextBox();
            this.soD_ComboBox1 = new SOD_ComboBox();
            this.cR_Subtitulos1 = new CR_Subtitulos();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cR_DataGriedView1 = new CR_DataGriedView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peticiones_Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peticiones_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cR_SplitContainer1)).BeginInit();
            this.cR_SplitContainer1.Panel1.SuspendLayout();
            this.cR_SplitContainer1.Panel2.SuspendLayout();
            this.cR_SplitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.cR_SplitContainer1.Panel1.Controls.Add(this.soD_TextBox1);
            this.cR_SplitContainer1.Panel1.Controls.Add(this.soD_ComboBox1);
            this.cR_SplitContainer1.Panel1.Controls.Add(this.cR_Subtitulos1);
            // 
            // cR_SplitContainer1.Panel2
            // 
            this.cR_SplitContainer1.Panel2.Controls.Add(this.panel1);
            this.cR_SplitContainer1.Size = new System.Drawing.Size(1105, 450);
            this.cR_SplitContainer1.SplitterDistance = 80;
            this.cR_SplitContainer1.TabIndex = 0;
            // 
            // soD_TextBox1
            // 
            this.soD_TextBox1.BorderColor = System.Drawing.Color.Yellow;
            this.soD_TextBox1.BorderFocusColor = System.Drawing.Color.Red;
            this.soD_TextBox1.BorderSize = 2;
            this.soD_TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.soD_TextBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.soD_TextBox1.Location = new System.Drawing.Point(104, 46);
            this.soD_TextBox1.Name = "soD_TextBox1";
            this.soD_TextBox1.Size = new System.Drawing.Size(100, 21);
            this.soD_TextBox1.TabIndex = 2;
            // 
            // soD_ComboBox1
            // 
            this.soD_ComboBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.soD_ComboBox1.FormattingEnabled = true;
            this.soD_ComboBox1.Items.AddRange(new object[] {
            "Cliente",
            "Serial"});
            this.soD_ComboBox1.Location = new System.Drawing.Point(8, 41);
            this.soD_ComboBox1.Name = "soD_ComboBox1";
            this.soD_ComboBox1.Size = new System.Drawing.Size(90, 27);
            this.soD_ComboBox1.TabIndex = 1;
            this.soD_ComboBox1.Text = "Buscar por:";
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
            this.cR_Subtitulos1.Location = new System.Drawing.Point(386, 9);
            this.cR_Subtitulos1.Name = "cR_Subtitulos1";
            this.cR_Subtitulos1.Size = new System.Drawing.Size(168, 31);
            this.cR_Subtitulos1.TabIndex = 0;
            this.cR_Subtitulos1.Text = "Ver Entradas";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cR_DataGriedView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 366);
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
            this.Column1,
            this.Peticiones_Client,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Peticiones_Date,
            this.Column6});
            this.cR_DataGriedView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cR_DataGriedView1.EnableHeadersVisualStyles = false;
            this.cR_DataGriedView1.Location = new System.Drawing.Point(0, 0);
            this.cR_DataGriedView1.Name = "cR_DataGriedView1";
            this.cR_DataGriedView1.ReadOnly = true;
            this.cR_DataGriedView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cR_DataGriedView1.Size = new System.Drawing.Size(1105, 366);
            this.cR_DataGriedView1.TabIndex = 1;
            this.cR_DataGriedView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cR_DataGriedView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tecnico";
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
            // Column2
            // 
            this.Column2.HeaderText = "Equipo";
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
            // Peticiones_Date
            // 
            this.Peticiones_Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Peticiones_Date.HeaderText = "Fecha";
            this.Peticiones_Date.Name = "Peticiones_Date";
            this.Peticiones_Date.ReadOnly = true;
            this.Peticiones_Date.Width = 73;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Fallo";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // VisualizarEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 450);
            this.Controls.Add(this.cR_SplitContainer1);
            this.Name = "VisualizarEntradas";
            this.Text = "Ver entradas de equipos";
            this.cR_SplitContainer1.Panel1.ResumeLayout(false);
            this.cR_SplitContainer1.Panel1.PerformLayout();
            this.cR_SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cR_SplitContainer1)).EndInit();
            this.cR_SplitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cR_DataGriedView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_SplitContainer cR_SplitContainer1;
        private CR_Subtitulos cR_Subtitulos1;
        private System.Windows.Forms.Panel panel1;
        private CR_DataGriedView cR_DataGriedView1;
        private SOD_ComboBox soD_ComboBox1;
        private SOD_TextBox soD_TextBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peticiones_Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peticiones_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}
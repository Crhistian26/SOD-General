namespace SOD_General.Vistas.Taller.Pruebadiseño
{
    partial class AddContact
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
            this.cR_SplitContainer1 = new CR_SplitContainer();
            this.cR_Subtitulos1 = new CR_Subtitulos();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cR_LabelDown6 = new CR_LabelDown();
            this.cbRnc = new Cr_ComboBox();
            this.cbRncContact = new CR_LabelDown();
            this.cbClient = new Cr_ComboBox();
            this.txtPhone1Ctc = new Cr_Textbox();
            this.txtNombreCtc = new Cr_Textbox();
            this.cR_LabelDown4 = new CR_LabelDown();
            this.btnAgregContact = new Diseños.Botones_Nuevos();
            this.cR_LabelDown3 = new CR_LabelDown();
            this.txtPhone2Ctc = new Cr_Textbox();
            this.cR_LabelDown1 = new CR_LabelDown();
            ((System.ComponentModel.ISupportInitialize)(this.cR_SplitContainer1)).BeginInit();
            this.cR_SplitContainer1.Panel1.SuspendLayout();
            this.cR_SplitContainer1.Panel2.SuspendLayout();
            this.cR_SplitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.cR_SplitContainer1.Size = new System.Drawing.Size(691, 357);
            this.cR_SplitContainer1.SplitterDistance = 80;
            this.cR_SplitContainer1.TabIndex = 2;
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
            this.cR_Subtitulos1.Location = new System.Drawing.Point(234, 26);
            this.cR_Subtitulos1.Name = "cR_Subtitulos1";
            this.cR_Subtitulos1.Size = new System.Drawing.Size(229, 31);
            this.cR_Subtitulos1.TabIndex = 0;
            this.cR_Subtitulos1.Text = "Agregar Contacto";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cR_LabelDown6);
            this.panel1.Controls.Add(this.cbRnc);
            this.panel1.Controls.Add(this.cbRncContact);
            this.panel1.Controls.Add(this.cbClient);
            this.panel1.Controls.Add(this.txtPhone1Ctc);
            this.panel1.Controls.Add(this.txtNombreCtc);
            this.panel1.Controls.Add(this.cR_LabelDown4);
            this.panel1.Controls.Add(this.btnAgregContact);
            this.panel1.Controls.Add(this.cR_LabelDown3);
            this.panel1.Controls.Add(this.txtPhone2Ctc);
            this.panel1.Controls.Add(this.cR_LabelDown1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 273);
            this.panel1.TabIndex = 1;
            // 
            // cR_LabelDown6
            // 
            this.cR_LabelDown6.AutoSize = true;
            this.cR_LabelDown6.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.cR_LabelDown6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.cR_LabelDown6.Location = new System.Drawing.Point(126, 172);
            this.cR_LabelDown6.Name = "cR_LabelDown6";
            this.cR_LabelDown6.Size = new System.Drawing.Size(120, 20);
            this.cR_LabelDown6.TabIndex = 81;
            this.cR_LabelDown6.Text = "Cliente asociado";
            // 
            // cbRnc
            // 
            this.cbRnc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbRnc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbRnc.BackColor = System.Drawing.Color.White;
            this.cbRnc.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cbRnc.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cbRnc.FormattingEnabled = true;
            this.cbRnc.Location = new System.Drawing.Point(59, 113);
            this.cbRnc.Name = "cbRnc";
            this.cbRnc.Size = new System.Drawing.Size(232, 29);
            this.cbRnc.TabIndex = 80;
            this.cbRnc.SelectedIndexChanged += new System.EventHandler(this.CbRnc_SelectedIndexChanged);
            // 
            // cbRncContact
            // 
            this.cbRncContact.AutoSize = true;
            this.cbRncContact.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.cbRncContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.cbRncContact.Location = new System.Drawing.Point(131, 90);
            this.cbRncContact.Name = "cbRncContact";
            this.cbRncContact.Size = new System.Drawing.Size(98, 20);
            this.cbRncContact.TabIndex = 78;
            this.cbRncContact.Text = "Rnc o Cedula";
            // 
            // cbClient
            // 
            this.cbClient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbClient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbClient.BackColor = System.Drawing.Color.White;
            this.cbClient.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cbClient.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(59, 196);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(232, 29);
            this.cbClient.TabIndex = 77;
            // 
            // txtPhone1Ctc
            // 
            this.txtPhone1Ctc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone1Ctc.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.txtPhone1Ctc.Location = new System.Drawing.Point(360, 37);
            this.txtPhone1Ctc.Name = "txtPhone1Ctc";
            this.txtPhone1Ctc.Size = new System.Drawing.Size(232, 25);
            this.txtPhone1Ctc.TabIndex = 11;
            // 
            // txtNombreCtc
            // 
            this.txtNombreCtc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreCtc.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.txtNombreCtc.Location = new System.Drawing.Point(59, 37);
            this.txtNombreCtc.Name = "txtNombreCtc";
            this.txtNombreCtc.Size = new System.Drawing.Size(232, 25);
            this.txtNombreCtc.TabIndex = 10;
            // 
            // cR_LabelDown4
            // 
            this.cR_LabelDown4.AutoSize = true;
            this.cR_LabelDown4.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.cR_LabelDown4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.cR_LabelDown4.Location = new System.Drawing.Point(426, 14);
            this.cR_LabelDown4.Name = "cR_LabelDown4";
            this.cR_LabelDown4.Size = new System.Drawing.Size(93, 20);
            this.cR_LabelDown4.TabIndex = 8;
            this.cR_LabelDown4.Text = "1er Numero ";
            // 
            // btnAgregContact
            // 
            this.btnAgregContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(118)))));
            this.btnAgregContact.BorderColor = System.Drawing.Color.Teal;
            this.btnAgregContact.BorderRadius = 40;
            this.btnAgregContact.BorderSize = 0;
            this.btnAgregContact.FlatAppearance.BorderSize = 0;
            this.btnAgregContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregContact.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAgregContact.ForeColor = System.Drawing.Color.White;
            this.btnAgregContact.Location = new System.Drawing.Point(360, 184);
            this.btnAgregContact.Name = "btnAgregContact";
            this.btnAgregContact.Size = new System.Drawing.Size(232, 41);
            this.btnAgregContact.TabIndex = 6;
            this.btnAgregContact.Text = "Agregar Contacto";
            this.btnAgregContact.UseVisualStyleBackColor = false;
            this.btnAgregContact.Click += new System.EventHandler(this.btnAgregContact_Click);
            // 
            // cR_LabelDown3
            // 
            this.cR_LabelDown3.AutoSize = true;
            this.cR_LabelDown3.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.cR_LabelDown3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.cR_LabelDown3.Location = new System.Drawing.Point(425, 90);
            this.cR_LabelDown3.Name = "cR_LabelDown3";
            this.cR_LabelDown3.Size = new System.Drawing.Size(94, 20);
            this.cR_LabelDown3.TabIndex = 5;
            this.cR_LabelDown3.Text = "2do Numero";
            // 
            // txtPhone2Ctc
            // 
            this.txtPhone2Ctc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone2Ctc.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.txtPhone2Ctc.Location = new System.Drawing.Point(360, 117);
            this.txtPhone2Ctc.Name = "txtPhone2Ctc";
            this.txtPhone2Ctc.Size = new System.Drawing.Size(232, 25);
            this.txtPhone2Ctc.TabIndex = 4;
            // 
            // cR_LabelDown1
            // 
            this.cR_LabelDown1.AutoSize = true;
            this.cR_LabelDown1.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.cR_LabelDown1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.cR_LabelDown1.Location = new System.Drawing.Point(135, 14);
            this.cR_LabelDown1.Name = "cR_LabelDown1";
            this.cR_LabelDown1.Size = new System.Drawing.Size(64, 20);
            this.cR_LabelDown1.TabIndex = 1;
            this.cR_LabelDown1.Text = "Nombre";
            // 
            // AddContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 357);
            this.Controls.Add(this.cR_SplitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AddContact";
            this.Text = "AddContact";
            this.Load += new System.EventHandler(this.AddContact_Load);
            this.cR_SplitContainer1.Panel1.ResumeLayout(false);
            this.cR_SplitContainer1.Panel1.PerformLayout();
            this.cR_SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cR_SplitContainer1)).EndInit();
            this.cR_SplitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_SplitContainer cR_SplitContainer1;
        private CR_Subtitulos cR_Subtitulos1;
        private System.Windows.Forms.Panel panel1;
        private CR_LabelDown cR_LabelDown4;
        private Diseños.Botones_Nuevos btnAgregContact;
        private CR_LabelDown cR_LabelDown3;
        private Cr_Textbox txtPhone2Ctc;
        private CR_LabelDown cR_LabelDown1;
        private Cr_Textbox txtPhone1Ctc;
        private Cr_Textbox txtNombreCtc;
        private CR_LabelDown cbRncContact;
        public Cr_ComboBox cbClient;
        private CR_LabelDown cR_LabelDown6;
        public Cr_ComboBox cbRnc;
    }
}
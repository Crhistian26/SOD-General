namespace SOD_General.Vistas.Taller.Pruebadiseño
{
    partial class AddEnterprise
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
            this.panelCliente = new System.Windows.Forms.Panel();
            this.cR_Subtitulos2 = new CR_Subtitulos();
            this.txtRNC = new Cr_Textbox();
            this.btn_AgregarRNC = new Diseños.Botones_Nuevos();
            ((System.ComponentModel.ISupportInitialize)(this.cR_SplitContainer1)).BeginInit();
            this.cR_SplitContainer1.Panel1.SuspendLayout();
            this.cR_SplitContainer1.Panel2.SuspendLayout();
            this.cR_SplitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelCliente.SuspendLayout();
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
            this.cR_SplitContainer1.Size = new System.Drawing.Size(442, 252);
            this.cR_SplitContainer1.SplitterDistance = 80;
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
            this.cR_Subtitulos1.Location = new System.Drawing.Point(97, 32);
            this.cR_Subtitulos1.Name = "cR_Subtitulos1";
            this.cR_Subtitulos1.Size = new System.Drawing.Size(258, 31);
            this.cR_Subtitulos1.TabIndex = 0;
            this.cR_Subtitulos1.Text = "Agregar Rnc/Cedula";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelCliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 168);
            this.panel1.TabIndex = 1;
            // 
            // panelCliente
            // 
            this.panelCliente.Controls.Add(this.cR_Subtitulos2);
            this.panelCliente.Controls.Add(this.txtRNC);
            this.panelCliente.Controls.Add(this.btn_AgregarRNC);
            this.panelCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCliente.Location = new System.Drawing.Point(0, 0);
            this.panelCliente.Name = "panelCliente";
            this.panelCliente.Size = new System.Drawing.Size(442, 168);
            this.panelCliente.TabIndex = 45;
            // 
            // cR_Subtitulos2
            // 
            this.cR_Subtitulos2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cR_Subtitulos2.AutoSize = true;
            this.cR_Subtitulos2.BackColor = System.Drawing.Color.Transparent;
            this.cR_Subtitulos2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cR_Subtitulos2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.cR_Subtitulos2.Location = new System.Drawing.Point(160, 16);
            this.cR_Subtitulos2.Name = "cR_Subtitulos2";
            this.cR_Subtitulos2.Size = new System.Drawing.Size(118, 25);
            this.cR_Subtitulos2.TabIndex = 72;
            this.cR_Subtitulos2.Text = "Rnc/Cedula";
            // 
            // txtRNC
            // 
            this.txtRNC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRNC.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.txtRNC.Location = new System.Drawing.Point(103, 44);
            this.txtRNC.Multiline = true;
            this.txtRNC.Name = "txtRNC";
            this.txtRNC.Size = new System.Drawing.Size(227, 30);
            this.txtRNC.TabIndex = 73;
            // 
            // btn_AgregarRNC
            // 
            this.btn_AgregarRNC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(118)))));
            this.btn_AgregarRNC.BorderColor = System.Drawing.Color.Teal;
            this.btn_AgregarRNC.BorderRadius = 40;
            this.btn_AgregarRNC.BorderSize = 0;
            this.btn_AgregarRNC.FlatAppearance.BorderSize = 0;
            this.btn_AgregarRNC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarRNC.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_AgregarRNC.ForeColor = System.Drawing.Color.White;
            this.btn_AgregarRNC.Location = new System.Drawing.Point(125, 91);
            this.btn_AgregarRNC.Name = "btn_AgregarRNC";
            this.btn_AgregarRNC.Size = new System.Drawing.Size(192, 39);
            this.btn_AgregarRNC.TabIndex = 62;
            this.btn_AgregarRNC.Text = "Agregar";
            this.btn_AgregarRNC.UseVisualStyleBackColor = false;
            this.btn_AgregarRNC.Click += new System.EventHandler(this.btn_AgregarRNC_Click);
            // 
            // AddEnterprise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 252);
            this.Controls.Add(this.cR_SplitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEnterprise";
            this.Text = "AddEnterprise";
            this.cR_SplitContainer1.Panel1.ResumeLayout(false);
            this.cR_SplitContainer1.Panel1.PerformLayout();
            this.cR_SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cR_SplitContainer1)).EndInit();
            this.cR_SplitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelCliente.ResumeLayout(false);
            this.panelCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CR_SplitContainer cR_SplitContainer1;
        private CR_Subtitulos cR_Subtitulos1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelCliente;
        private CR_Subtitulos cR_Subtitulos2;
        private Cr_Textbox txtRNC;
        private Diseños.Botones_Nuevos btn_AgregarRNC;
    }
}
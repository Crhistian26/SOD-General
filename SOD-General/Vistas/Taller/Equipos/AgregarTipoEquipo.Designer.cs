namespace SOD_General.Vistas.Taller.Equipos
{
    partial class AgregarTipoEquipo
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
            this.fR_TextBox1 = new Designer.FR_TextBox();
            this.cR_Checkbox1 = new CR_Checkbox();
            this.cR_LabelDown1 = new CR_LabelDown();
            this.botones_Nuevos1 = new Diseños.Botones_Nuevos();
            ((System.ComponentModel.ISupportInitialize)(this.cR_SplitContainer1)).BeginInit();
            this.cR_SplitContainer1.Panel1.SuspendLayout();
            this.cR_SplitContainer1.Panel2.SuspendLayout();
            this.cR_SplitContainer1.SuspendLayout();
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
            this.cR_SplitContainer1.Panel2.Controls.Add(this.fR_TextBox1);
            this.cR_SplitContainer1.Panel2.Controls.Add(this.cR_Checkbox1);
            this.cR_SplitContainer1.Panel2.Controls.Add(this.cR_LabelDown1);
            this.cR_SplitContainer1.Panel2.Controls.Add(this.botones_Nuevos1);
            this.cR_SplitContainer1.Size = new System.Drawing.Size(291, 264);
            this.cR_SplitContainer1.SplitterDistance = 65;
            this.cR_SplitContainer1.TabIndex = 4;
            // 
            // cR_Subtitulos1
            // 
            this.cR_Subtitulos1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cR_Subtitulos1.AutoSize = true;
            this.cR_Subtitulos1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.cR_Subtitulos1.Font = new System.Drawing.Font("Microsoft YaHei", 14.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cR_Subtitulos1.ForeColor = System.Drawing.Color.White;
            this.cR_Subtitulos1.Location = new System.Drawing.Point(7, 21);
            this.cR_Subtitulos1.Name = "cR_Subtitulos1";
            this.cR_Subtitulos1.Size = new System.Drawing.Size(246, 27);
            this.cR_Subtitulos1.TabIndex = 1;
            this.cR_Subtitulos1.Text = "Agregar tipo de equipo";
            this.cR_Subtitulos1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fR_TextBox1
            // 
            this.fR_TextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.fR_TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(123)))), ((int)(((byte)(134)))));
            this.fR_TextBox1.BorderFocusColor = System.Drawing.Color.Blue;
            this.fR_TextBox1.BorderSize = 2;
            this.fR_TextBox1.Location = new System.Drawing.Point(67, 41);
            this.fR_TextBox1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.fR_TextBox1.Multiline = true;
            this.fR_TextBox1.Name = "fR_TextBox1";
            this.fR_TextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.fR_TextBox1.PasswordChar = false;
            this.fR_TextBox1.Size = new System.Drawing.Size(141, 30);
            this.fR_TextBox1.TabIndex = 33;
            this.fR_TextBox1.texts = "";
            this.fR_TextBox1.UnderlinedStyle = false;
            // 
            // cR_Checkbox1
            // 
            this.cR_Checkbox1.AutoSize = true;
            this.cR_Checkbox1.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.cR_Checkbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.cR_Checkbox1.Location = new System.Drawing.Point(103, 82);
            this.cR_Checkbox1.Name = "cR_Checkbox1";
            this.cR_Checkbox1.Size = new System.Drawing.Size(70, 24);
            this.cR_Checkbox1.TabIndex = 32;
            this.cR_Checkbox1.Text = "Activo";
            this.cR_Checkbox1.UseVisualStyleBackColor = true;
            // 
            // cR_LabelDown1
            // 
            this.cR_LabelDown1.AutoSize = true;
            this.cR_LabelDown1.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.cR_LabelDown1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.cR_LabelDown1.Location = new System.Drawing.Point(76, 18);
            this.cR_LabelDown1.Name = "cR_LabelDown1";
            this.cR_LabelDown1.Size = new System.Drawing.Size(112, 20);
            this.cR_LabelDown1.TabIndex = 7;
            this.cR_LabelDown1.Text = "Tipo de equipo";
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
            this.botones_Nuevos1.Location = new System.Drawing.Point(67, 136);
            this.botones_Nuevos1.Name = "botones_Nuevos1";
            this.botones_Nuevos1.Size = new System.Drawing.Size(141, 39);
            this.botones_Nuevos1.TabIndex = 5;
            this.botones_Nuevos1.Text = "Guardar";
            this.botones_Nuevos1.UseVisualStyleBackColor = false;
            // 
            // AgregarTipoEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 264);
            this.Controls.Add(this.cR_SplitContainer1);
            this.Name = "AgregarTipoEquipo";
            this.Text = "AgregarTipoEquipo";
            this.cR_SplitContainer1.Panel1.ResumeLayout(false);
            this.cR_SplitContainer1.Panel1.PerformLayout();
            this.cR_SplitContainer1.Panel2.ResumeLayout(false);
            this.cR_SplitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cR_SplitContainer1)).EndInit();
            this.cR_SplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CR_SplitContainer cR_SplitContainer1;
        private CR_Subtitulos cR_Subtitulos1;
        private Designer.FR_TextBox fR_TextBox1;
        private CR_Checkbox cR_Checkbox1;
        private CR_LabelDown cR_LabelDown1;
        private Diseños.Botones_Nuevos botones_Nuevos1;
    }
}
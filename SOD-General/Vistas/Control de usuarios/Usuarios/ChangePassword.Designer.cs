namespace SOD_General.Vistas.Control_de_usuarios.Usuarios
{
    partial class ChangePassword
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
            this.botones_Nuevos1 = new Diseños.Botones_Nuevos();
            this.cr_Textbox2 = new Cr_Textbox();
            this.cR_LabelDown2 = new CR_LabelDown();
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
            this.cR_SplitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.cR_SplitContainer1.Panel2.Controls.Add(this.botones_Nuevos1);
            this.cR_SplitContainer1.Panel2.Controls.Add(this.cr_Textbox2);
            this.cR_SplitContainer1.Panel2.Controls.Add(this.cR_LabelDown2);
            this.cR_SplitContainer1.Size = new System.Drawing.Size(467, 274);
            this.cR_SplitContainer1.SplitterDistance = 60;
            this.cR_SplitContainer1.SplitterWidth = 5;
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
            this.cR_Subtitulos1.Location = new System.Drawing.Point(76, 11);
            this.cR_Subtitulos1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cR_Subtitulos1.Name = "cR_Subtitulos1";
            this.cR_Subtitulos1.Size = new System.Drawing.Size(286, 40);
            this.cR_Subtitulos1.TabIndex = 0;
            this.cR_Subtitulos1.Text = "Nueva contraseña";
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
            this.botones_Nuevos1.Location = new System.Drawing.Point(105, 101);
            this.botones_Nuevos1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botones_Nuevos1.Name = "botones_Nuevos1";
            this.botones_Nuevos1.Size = new System.Drawing.Size(247, 49);
            this.botones_Nuevos1.TabIndex = 8;
            this.botones_Nuevos1.Text = "Guardar";
            this.botones_Nuevos1.UseVisualStyleBackColor = false;
            this.botones_Nuevos1.Click += new System.EventHandler(this.Change_Password);
            // 
            // cr_Textbox2
            // 
            this.cr_Textbox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cr_Textbox2.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.cr_Textbox2.Location = new System.Drawing.Point(84, 47);
            this.cr_Textbox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cr_Textbox2.Name = "cr_Textbox2";
            this.cr_Textbox2.Size = new System.Drawing.Size(282, 29);
            this.cr_Textbox2.TabIndex = 6;
            // 
            // cR_LabelDown2
            // 
            this.cR_LabelDown2.AutoSize = true;
            this.cR_LabelDown2.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.cR_LabelDown2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.cR_LabelDown2.Location = new System.Drawing.Point(100, 18);
            this.cR_LabelDown2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cR_LabelDown2.Name = "cR_LabelDown2";
            this.cR_LabelDown2.Size = new System.Drawing.Size(157, 23);
            this.cR_LabelDown2.TabIndex = 7;
            this.cR_LabelDown2.Text = "Contraseña nueva:";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 274);
            this.Controls.Add(this.cR_SplitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
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
        private Cr_Textbox cr_Textbox2;
        private CR_LabelDown cR_LabelDown2;
        private Diseños.Botones_Nuevos botones_Nuevos1;
    }
}
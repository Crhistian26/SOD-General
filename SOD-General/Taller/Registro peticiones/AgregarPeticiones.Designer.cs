namespace SOD_General.Taller.Registro_peticiones
{
    partial class AgregarPeticiones
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
            this.fR_Panel1 = new Designer.FR_Panel();
            this.fR_LineaDivisora1 = new Designer.FR_LineaDivisora();
            this.fR_SubTitulo1 = new Designer.FR_SubTitulo();
            this.fR_Titulos1 = new Designer.FR_Titulos();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // fR_Panel1
            // 
            this.fR_Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fR_Panel1.Location = new System.Drawing.Point(0, 0);
            this.fR_Panel1.Name = "fR_Panel1";
            this.fR_Panel1.Size = new System.Drawing.Size(1152, 540);
            this.fR_Panel1.TabIndex = 0;
            // 
            // fR_LineaDivisora1
            // 
            this.fR_LineaDivisora1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(118)))));
            this.fR_LineaDivisora1.Location = new System.Drawing.Point(0, 0);
            this.fR_LineaDivisora1.Name = "fR_LineaDivisora1";
            this.fR_LineaDivisora1.Size = new System.Drawing.Size(800, 90);
            this.fR_LineaDivisora1.TabIndex = 1;
            // 
            // fR_SubTitulo1
            // 
            this.fR_SubTitulo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(118)))));
            this.fR_SubTitulo1.Location = new System.Drawing.Point(163, 45);
            this.fR_SubTitulo1.Name = "fR_SubTitulo1";
            this.fR_SubTitulo1.Size = new System.Drawing.Size(461, 45);
            this.fR_SubTitulo1.TabIndex = 2;
            // 
            // fR_Titulos1
            // 
            this.fR_Titulos1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(118)))));
            this.fR_Titulos1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fR_Titulos1.Location = new System.Drawing.Point(305, 0);
            this.fR_Titulos1.Name = "fR_Titulos1";
            this.fR_Titulos1.Padding = new System.Windows.Forms.Padding(2);
            this.fR_Titulos1.Size = new System.Drawing.Size(123, 59);
            this.fR_Titulos1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(37, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 306);
            this.dataGridView1.TabIndex = 5;
            // 
            // AgregarPeticiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 540);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fR_Titulos1);
            this.Controls.Add(this.fR_SubTitulo1);
            this.Controls.Add(this.fR_LineaDivisora1);
            this.Controls.Add(this.fR_Panel1);
            this.Name = "AgregarPeticiones";
            this.Text = "AgregarPeticiones";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Designer.FR_Panel fR_Panel1;
        private Designer.FR_LineaDivisora fR_LineaDivisora1;
        private Designer.FR_SubTitulo fR_SubTitulo1;
        private Designer.FR_Titulos fR_Titulos1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
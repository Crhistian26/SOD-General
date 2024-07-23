namespace SOD_General.Vistas.Recursos_Humanos.Empleados
{
    partial class Empleado_Details
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
            this.cR_DateTimePicker1 = new CR_DateTimePicker();
            this.cR_DateTimePicker2 = new CR_DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.cR_SplitContainer1)).BeginInit();
            this.cR_SplitContainer1.Panel1.SuspendLayout();
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
            this.cR_SplitContainer1.Panel1.Controls.Add(this.cR_DateTimePicker2);
            this.cR_SplitContainer1.Panel1.Controls.Add(this.cR_DateTimePicker1);
            this.cR_SplitContainer1.Panel1.Controls.Add(this.cR_Subtitulos1);
            this.cR_SplitContainer1.Size = new System.Drawing.Size(800, 450);
            this.cR_SplitContainer1.SplitterDistance = 118;
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
            this.cR_Subtitulos1.Location = new System.Drawing.Point(354, 9);
            this.cR_Subtitulos1.Name = "cR_Subtitulos1";
            this.cR_Subtitulos1.Size = new System.Drawing.Size(114, 31);
            this.cR_Subtitulos1.TabIndex = 0;
            this.cR_Subtitulos1.Text = "Nombre";
            // 
            // cR_DateTimePicker1
            // 
            this.cR_DateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 11F);
            this.cR_DateTimePicker1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.cR_DateTimePicker1.Location = new System.Drawing.Point(252, 81);
            this.cR_DateTimePicker1.Name = "cR_DateTimePicker1";
            this.cR_DateTimePicker1.Size = new System.Drawing.Size(265, 24);
            this.cR_DateTimePicker1.TabIndex = 1;
            // 
            // cR_DateTimePicker2
            // 
            this.cR_DateTimePicker2.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 11F);
            this.cR_DateTimePicker2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.cR_DateTimePicker2.Location = new System.Drawing.Point(523, 81);
            this.cR_DateTimePicker2.Name = "cR_DateTimePicker2";
            this.cR_DateTimePicker2.Size = new System.Drawing.Size(265, 24);
            this.cR_DateTimePicker2.TabIndex = 2;
            // 
            // Empleado_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cR_SplitContainer1);
            this.Name = "Empleado_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleado_Details";
            this.Load += new System.EventHandler(this.Empleado_Details_Load);
            this.Resize += new System.EventHandler(this.Empleado_Details_Resize);
            this.cR_SplitContainer1.Panel1.ResumeLayout(false);
            this.cR_SplitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cR_SplitContainer1)).EndInit();
            this.cR_SplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CR_SplitContainer cR_SplitContainer1;
        private CR_Subtitulos cR_Subtitulos1;
        private CR_DateTimePicker cR_DateTimePicker2;
        private CR_DateTimePicker cR_DateTimePicker1;
    }
}
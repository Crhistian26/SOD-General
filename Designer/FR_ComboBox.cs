using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Designer
{
    [DefaultEvent("OnSelectedIndexChanged")]
    public class FR_ComboBox : UserControl
    {
        //campos
        private Color backColor = Color.White;
        private Color iconColor = Color.White;
        private Color listBackColor = Color.Blue;
        private Color listTextColor = Color.Black;
        private Color borderColor = Color.FromArgb(39, 123, 134);
        private int borderSize = 2;

        //objetos
        private ComboBox combList;
        private Label lblText;
        private Button btnIcon;

        public new Color BackColor
        { 
            get
            {
                return backColor;
            }       
            
            set
            {
                backColor = value;
                lblText.BackColor = backColor;
                btnIcon.BackColor = backColor;
            }
                
        }

        public Color IconColor 
        {
            get
            {
                return iconColor;
            } 
            
            set
            {
                iconColor = value;
                this.Invalidate();
            }
                
        }

        public Color ListBackColor 
        { 
            get
            {
                return listBackColor;
            }
                 
            set
            {
                listBackColor = value;
                combList.BackColor = listBackColor;
            } 
                 
        }

        public Color ListTextColor 
        {
            get
            {
                return listTextColor;
            } 
                 

            set
            {
                listTextColor = value;
                combList.ForeColor = listTextColor;
            } 
                 
            
        }

        public Color BorderColor 
        {
            get
            {
                return borderColor;
            } 
                
            set
            {
                borderColor = value;
                base.BackColor = borderColor;
            }
                 
        }

        public int BorderSize 
        { 
            get
            {
               return borderSize;
            }

            set
            {
                borderSize = value;
                this.Padding = new Padding(borderSize);
                AdjustComboBoxDimensions();
            }
        }

        public override Color ForeColor 
        { 
            get
            {
              return base.ForeColor;
            } 
            
            set
            {
                base.ForeColor = value;
                lblText.ForeColor = value;
            } 
        }

        public override Font Font
        {
            get
            {
                return base.Font;
            }

            set
            {
                base.Font = value;
                lblText.Font = value;
                combList.Font = value;
            }
        }

        public string Texto
        {
            get
            {
                return lblText.Text;
            }

            set
            {
                lblText.Text = value;
            }
        }

        public ComboBoxStyle DropDownStyle
        {
            get
            {
                return combList.DropDownStyle;
            }

            set
            {
                combList.DropDownStyle = value;
            }
        }

        //eventos
        public event EventHandler OnSelectedIndexChanged;

        //constructor

        public FR_ComboBox()
        {
            combList = new ComboBox();
            lblText = new Label();
            btnIcon = new Button();

            //bajar combo box
            combList.BackColor = listBackColor;
            combList.ForeColor = listTextColor;
            combList.Font = new Font(this.Font.Name, 10F);
            combList.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
            combList.TextChanged += new EventHandler(ComboBox_TextChanged);

            //icono boton
            btnIcon.Dock = DockStyle.Right;
            btnIcon.FlatStyle = FlatStyle.Flat;
            btnIcon.FlatAppearance.BorderSize = 0;
            btnIcon.Size = new Size(30, 30);
            btnIcon.Cursor = Cursors.Hand;
            btnIcon.Click += new EventHandler(Icon_Click);
            btnIcon.Paint += new PaintEventHandler(Icon_Paint);

            //label
            lblText.Dock = DockStyle.Fill;
            lblText.AutoSize = false;
            lblText.BackColor = backColor;
            lblText.TextAlign = ContentAlignment.MiddleLeft;
            lblText.Padding = new Padding(8, 0, 0, 0);
            lblText.Font = new Font(this.Font.Name, 10F);
            lblText.Click += new EventHandler(Surface_Click);


            //usuario control
            this.Controls.Add(lblText);
            this.Controls.Add(btnIcon);
            this.Controls.Add(combList);
            this.MinimumSize = new Size(200, 30);
            this.Size = new Size(200, 30);
            this.Padding = new Padding(borderSize);
            base.BackColor = borderColor;
            this.ResumeLayout();
            AdjustComboBoxDimensions();
        }

        //metodos privados
        private void AdjustComboBoxDimensions()
        {
            combList.Width = lblText.Width;
            combList.Location = new Point()
            {
                X = this.Width - this.Padding.Right - combList.Width,
                Y = lblText.Bottom - combList.Height
            };
        }


        private void Surface_Click(object sender, EventArgs e)
        {
            combList.Select();
            if (combList.DropDownStyle == ComboBoxStyle.DropDownList)
            {
                combList.DroppedDown = true;
            }
        }

        private void Icon_Paint(object sender, PaintEventArgs e)
        {
            //campos
            int iconWidth = 14;
            int iconHeight = 6;
            var rectIcon = new Rectangle((btnIcon.Width - iconWidth) / 2, (btnIcon.Height - iconHeight) / 2, iconWidth, iconHeight);
            Graphics graph = e.Graphics;

            //dibujo flecha abajo
            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(iconColor, 2))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + (iconWidth / 2), rectIcon.Bottom);
                path.AddLine(rectIcon.X + (iconWidth / 2), rectIcon.Bottom, rectIcon.Right, rectIcon.Y);
                graph.DrawPath(pen, path);

            }

        }

        private void Icon_Click(object sender, EventArgs e)
        {
            combList.Select();
            combList.DroppedDown = true;
        }

        private void ComboBox_TextChanged(object sender, EventArgs e)
        {
            lblText.Text = combList.Text;
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OnSelectedIndexChanged != null)
            {
                OnSelectedIndexChanged.Invoke(sender, e);

            }
            else
            {
                lblText.Text = combList.Text;
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FR_ComboBox
            // 
            this.Name = "FR_ComboBox";
            this.Size = new System.Drawing.Size(314, 135);
            this.ResumeLayout(false);

        }

    }

}

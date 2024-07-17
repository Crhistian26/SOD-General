using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diseños
{
    [DefaultEvent("_TextChanged")]
    public partial class botonTexto : UserControl
    {
        private Color borderColor = Color.FromArgb(39, 123, 134);
        private int borderSize = 2;
        private bool underlinedstyle = false;
        private Color borderFocusColor = Color.Blue;
        private bool IsFocused = false;

        public botonTexto()
        {
            InitializeComponent();
        }

        public event EventHandler _TextChanged;
        public Color BorderColor
        {

            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                this.Invalidate();
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
                this.Invalidate();
            }
        }


        public bool Underlinedstyle
        {
            get
            {
                return underlinedstyle;
            }
            set
            {
                underlinedstyle = value;
                this.Invalidate();
            }
        }

        public bool passwordChar
        {
            get
            {
                return textBox1.UseSystemPasswordChar;
            }
            set
            {
                textBox1.UseSystemPasswordChar = value;
            }
        }

        public bool multiline
        {
            get
            {
                return textBox1.Multiline;
            }
            set
            {
                textBox1.Multiline = value;
            }
        }

        public override Color BackColor 
        {
            get 
            {
                return base.BackColor;
            }
            set 
            {
                base.BackColor = value;
                textBox1.BackColor = value;
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
                textBox1.ForeColor = value;
            } 
        }

        public override Font Font 
        {
            get
            {
                return base.Font ;
            }

            set
            {
                base.Font = value;
                textBox1.Font = value;

                if (this.DesignMode)
                {
                    updateControlHeight();
                }
            }
        }

        public override string Text
        {
            get
            {
                return textBox1.Text;
            }

            set
            {
                textBox1.Text = value;
            }
        }

        public Color BorderFocusColor 
        {
            get 
            {
                return borderFocusColor;
            }
            set
            {
                borderFocusColor = value;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                if (!IsFocused)
                {
                    if (underlinedstyle)
                    {
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else
                    {
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                    }
                }
                else
                {
                    penBorder.Color = BorderFocusColor;

                    if (underlinedstyle)
                    {
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else
                    {
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                    }
                }
            }

        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
            {
                updateControlHeight();
            }
            
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            updateControlHeight();
        }

        private void updateControlHeight()
        {
            if(textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0,txtHeight);
                textBox1.Multiline = false;
            
                this.Height = textBox1.Height+this.Padding.Top+this.Padding.Bottom;
            }
        }

        

      

        

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
            {
                _TextChanged.Invoke(sender, e);
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);

        }
        

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            this.IsFocused=true;
            this.Invalidate();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            this.IsFocused =false;
            this.Invalidate();
        }
    }
}

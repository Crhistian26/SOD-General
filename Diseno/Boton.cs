using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Diseños
{
    public class Boton : Button
    {
        private int borderSize = 0;
        private int borderRadius = 40;
        private Color borderColor = Color.Teal;

        public int BorderSize {
            get
            {
                return borderSize;
                this.Invalidate();
            }
            set
            {
                borderSize = value;
            } 
        
        }

        public int BorderRadius {
            get
            {
                return borderRadius;
                this.Invalidate();
            }
            set
            {
                borderRadius = value;
            }
        }

        public Color BorderColor
        {
            get
            {
                return borderColor;
                this.Invalidate();
            }
            set
            {
                borderColor = value;
            }
        }

        public Boton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.FromArgb(39, 123, 134);
            this.ForeColor = Color.White;
            this.Font = new Font("Microsoft YaHei UI", 12, FontStyle.Bold);
        }
        
        private GraphicsPath GetFigurePaths(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            
            path.AddArc(rect.X, rect.Height-radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurFace = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width-0.8f, this.Height-1);

            if (borderRadius > 2)
            {
                using (GraphicsPath pathSurFace = GetFigurePaths(rectSurFace, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePaths(rectBorder, borderRadius - 1F))

                using (Pen penSurFace = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    this.Region = new Region(pathSurFace);

                    e.Graphics.DrawPath(penSurFace, pathSurFace);

                    if (borderSize >= 2)
                    {
                        e.Graphics.DrawPath(penBorder, pathBorder);
                    }

                }
            
            }
            else
            {
                this.Region = new Region(rectSurFace);
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        e.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                } 
            }        
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                this.Invalidate();
            }
        }
    }
}



using System.Drawing;
using System.Drawing.Text;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;

public class SOD_CheckBox : CheckBox
{
    public SOD_CheckBox()
    {
        this.BackColor = System.Drawing.Color.FromArgb(0, 107, 118);
        this.ForeColor = System.Drawing.Color.White;
        //this.Size = new System.Drawing.Size(100,20);
        this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12, System.Drawing.FontStyle.Regular);
        this.Paint += new PaintEventHandler(this.OnPaint);
        this.Padding = new Padding(4,2,0,2);
    }

    private void OnPaint(object sender, PaintEventArgs e)
    {
        CheckBox btn = sender as CheckBox;
        if(btn != null )
        {
            Color borderColor = Color.White;
            int borderWidth = 1;

            ControlPaint.DrawBorder(e.Graphics,btn.ClientRectangle, 
                                    borderColor, borderWidth, ButtonBorderStyle.Solid,
                                    borderColor, borderWidth, ButtonBorderStyle.Solid,
                                    borderColor, borderWidth, ButtonBorderStyle.Solid,
                                    borderColor, borderWidth, ButtonBorderStyle.Solid);
        }
    }
}       

using System.Windows.Forms;
using System.Drawing;
using System.Runtime.Remoting.Channels;
public class SOD_ComboBox : ComboBox
{
    public SOD_ComboBox()
    {


        this.Font = new Font("Microsoft YaHei UI", 10, FontStyle.Regular);
        
    }


    private void OnPaint(object sender, PaintEventArgs e)
    {
        ComboBox Comb = sender as ComboBox;

        if (Comb != null)
        {
            Color borderColor = Color.FromArgb(0, 153, 168);
            int withBorder = 2;

            ControlPaint.DrawBorder(e.Graphics, Comb.ClientRectangle,

                                    borderColor, withBorder, ButtonBorderStyle.Solid,
                                    borderColor, withBorder, ButtonBorderStyle.Solid,
                                    borderColor, withBorder, ButtonBorderStyle.Solid,
                                    borderColor, withBorder, ButtonBorderStyle.Solid);

        }
    }
}


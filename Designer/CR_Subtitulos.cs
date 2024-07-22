using System.Drawing;
using System.Windows.Forms;

public class CR_Subtitulos : Label
{
    public CR_Subtitulos()
    {
        this.BackColor = System.Drawing.Color.FromArgb(0, 153, 168);
        this.Font = new Font("Microsoft YaHei", 16);
        this.Text = "Subtitulos";
        this.ForeColor = System.Drawing.Color.White;
    }
}

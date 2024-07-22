using System.Drawing;
using System.Windows.Forms;

public class CR_Subtitulos : Label
{
    public CR_Subtitulos()
    {
        this.BackColor = System.Drawing.Color.FromArgb(0, 153, 168);
        this.Font = new Font("Microsoft YaHei", 18);
        this.Text = "Subtitulos";
        this.ForeColor = System.Drawing.Color.White;
        this.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    }
}

using System.Windows.Forms;

public class CR_SplitContainer : SplitContainer
{
    public CR_SplitContainer()
    {
        this.Orientation = Orientation.Horizontal;
        this.FixedPanel = FixedPanel.Panel1;
        this.Panel1.BackColor = System.Drawing.Color.FromArgb(0, 153, 168);
    }
}
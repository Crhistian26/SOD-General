using System.Drawing;
using System.Windows.Forms;

public class Cr_Textbox : TextBox
{
    public Cr_Textbox()
    {
        this.BorderStyle = BorderStyle.FixedSingle;
        this.Font = new Font("Microsoft YaHei", 10);
        this.SelectionStart += 2;
    }
}

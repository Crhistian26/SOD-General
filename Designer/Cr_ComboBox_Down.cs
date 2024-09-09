using System.Drawing;
using System.Windows.Forms;

public class Cr_ComboBox_Up : ComboBox
{
    public Cr_ComboBox_Up()
    {
        this.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
        this.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        this.AutoCompleteSource = AutoCompleteSource.ListItems;
        this.Font = new Font("Microsoft YaHei", 12);
        this.ForeColor = Color.FromArgb(0, 153, 168);

    }
}

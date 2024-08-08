using System;
using System.Drawing;
using System.Windows.Forms;

public class Cr_ComboBox : ComboBox
{
    public Cr_ComboBox()
    {
        this.BackColor = System.Drawing.Color.FromArgb(0, 153, 168);
        this.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        this.AutoCompleteSource = AutoCompleteSource.ListItems;
        this.Font = new Font("Microsoft YaHei", 12);
        this.ForeColor = Color.White;
        
    }
}


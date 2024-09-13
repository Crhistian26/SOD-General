using System.Drawing;
using System.Windows.Forms;

public class CR_DataGriedViewNormal : DataGridView
{
    public CR_DataGriedViewNormal()
    {
        this.BackgroundColor = System.Drawing.Color.White;
        this.AllowUserToAddRows = false;
        this.AllowUserToDeleteRows = false;
        this.AllowDrop = false;
        this.EnableHeadersVisualStyles = false;
        this.ReadOnly = true;

        DataGridViewCellStyle data = new DataGridViewCellStyle();
        data.Font = new Font("Microsoft YaHei", 10);
        data.ForeColor = System.Drawing.Color.White;
        data.BackColor = System.Drawing.Color.FromArgb(0, 153, 168);


        this.ColumnHeadersDefaultCellStyle = data;
        this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    }
}


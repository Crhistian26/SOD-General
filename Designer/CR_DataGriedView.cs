using System.Drawing;
using System.Windows.Forms;

public class CR_DataGriedView : DataGridView
{
    public CR_DataGriedView() 
    {
        this.BackgroundColor = System.Drawing.Color.White;
        this.Dock = DockStyle.Fill;
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


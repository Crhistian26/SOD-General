using System;
using System.Drawing;
using System.Windows.Forms;

public class CR_TBhora : TextBox
{
    public CR_TBhora()
    {
        this.BorderStyle = BorderStyle.FixedSingle;
        this.Font = new Font("Microsoft YaHei", 10);
        this.Size = new System.Drawing.Size(42, 21);
        this.KeyPress += CR_TBnumerico_KeyPress;
        this.MaxLength = 2;
    }

    private void CR_TBnumerico_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
        {
            e.Handled = true;
        }
        else
        {
            string texto = this.Text + e.KeyChar;
            int hora = Convert.ToInt32(texto);
            if (hora < 0)
            {
                this.Text = "1";
            }
            else if (hora > 12)
            {
                this.Text = "12";
            }
        }

    }
}

using System;
using System.Drawing;
using System.Windows.Forms;
public class SOD_TextBox : TextBox
{
    private bool isFocused = false;
    private Color borderColorFocus = Color.Red;
    private Color borderColor = Color.Orange;
    private int borderSize = 3;

    public SOD_TextBox()
    {
        this.BorderStyle = BorderStyle.None;
        this.Font = new Font("Microsoft YaHei UI", 12, FontStyle.Regular);
        this.Padding = new Padding(borderSize); // Para dar espacio para el borde

        this.Enter += SOD_TextBox_Enter;
        this.Leave += SOD_TextBox_Leave;
        this.Paint += SOD_TextBox_Paint;
    }

    private void SOD_TextBox_Enter(object sender, EventArgs e)
    {
        isFocused = true;
        this.Invalidate(); // Redibuja el control
    }

    private void SOD_TextBox_Leave(object sender, EventArgs e)
    {
        isFocused = false;
        this.Invalidate(); // Redibuja el control
    }

    private void SOD_TextBox_Paint(object sender, PaintEventArgs e)
    {
        Graphics graph = e.Graphics;
        Rectangle rect = this.ClientRectangle;
        rect.Width -= 1;
        rect.Height -= 1;

        using (Pen penBorder = new Pen(isFocused ? borderColorFocus : borderColor, borderSize))
        {
            penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
            graph.DrawRectangle(penBorder, rect);
        }
    }

    public Color BorderFocusColor
    {
        get { return borderColorFocus; }
        set { borderColorFocus = value; Invalidate(); }
    }

    public Color BorderColor
    {
        get { return borderColor; }
        set { borderColor = value; Invalidate(); }
    }

    public int BorderSize
    {
        get { return borderSize; }
        set { borderSize = value; Invalidate(); }
    }
}








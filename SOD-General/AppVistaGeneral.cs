using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOD_General
{
    public partial class AppVistaGeneral : Form
    {
        
        public AppVistaGeneral()
        {
            InitializeComponent();
        }

        private void AppVistaGeneral_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            var Item = new ToolStripMenuItem("Saludos");
            var item2 = new ToolStripMenuItem("Hola");
            item2.Click += new EventHandler(hola);
            var item3 = new ToolStripMenuItem("Hola2");
            item3.Click += new EventHandler(hola);
            Item.DropDownItems.Add(item2);
            Item.DropDownItems.Add(item3);
            menuStrip1.Items.Add(Item);
        }

        private void hola(object sender, EventArgs e)
        {
            MessageBox.Show("funicon");
        }
    }
}

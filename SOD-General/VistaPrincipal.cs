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
    public partial class VistaPrincipal : Form
    {
        public VistaPrincipal()
        {
            InitializeComponent();
        }
        
        private void VistaPrincipal_Load(object sender, EventArgs e)
        {
            var Item = new ToolStripMenuItem("Saludos");
            var item2 = new ToolStripMenuItem("Hola");
            item2.Click += new EventHandler(hola);
            Item.DropDownItems.Add(item2);
            menuStrip1.Items.Add(Item);
        }
        private void hola(object sender, EventArgs e)
        {
            MessageBox.Show("funicon");
        }
    }
}

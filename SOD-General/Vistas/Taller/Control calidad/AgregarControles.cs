using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOD_General.Taller.Control_calidad
{
    public partial class AgregarControles : Form
    {
        public AgregarControles()
        {
            InitializeComponent();
        }

        private void botones_Nuevos1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nuevo control agregado con exito");
             
        }
    }
}

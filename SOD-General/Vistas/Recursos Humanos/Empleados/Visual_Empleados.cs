using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOD_General.Recursos_Humanos.Empleados
{
    public partial class Visual_Empleados : Form
    {
        public Visual_Empleados()
        {
            InitializeComponent();
        }


        private void cR_DataGriedView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Junciona");
        }

        private void Visual_Empleados_Load(object sender, EventArgs e)
        {
            
        }
    }
}

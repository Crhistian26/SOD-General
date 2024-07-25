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
    public partial class VisualizarControles : Form
    {
        public VisualizarControles()
        {
            InitializeComponent();
            cR_DataGriedView1.Rows.Add("Teclas Panel", "Fotocopiadora");
        }

        private void fR_SubTitulo1_Load(object sender, EventArgs e)
        {

        }

        private void botones_Nuevos1_Click(object sender, EventArgs e)
        {
            AgregarControles agregarControles = new AgregarControles();
            agregarControles.Show();
        }

        private void cR_DataGriedView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EditarControles editarCtrl  = new EditarControles();
            editarCtrl.Show();
        }
    }
}

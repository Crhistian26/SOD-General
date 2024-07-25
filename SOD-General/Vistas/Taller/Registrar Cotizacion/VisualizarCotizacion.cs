using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOD_General.Vistas.Taller.Registrar_Cotizacion
{
    public partial class VisualizarCotizacion : Form
    {
        public VisualizarCotizacion()
        {
            InitializeComponent();
            cR_DataGriedView2.Rows.Add(1000, "Impresora", "Tonel", 1, 500, DateTime.Now.ToString("dd-MM-yyyy"), "No imprimia");

        }

        private void Click_Editar(object sender, DataGridViewCellEventArgs e)
        {
            EditarCotizaciones editarCotiza = new EditarCotizaciones();
            editarCotiza.Show();
        }
    }
}

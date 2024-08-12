using Modelos.Taller;
using SOD_General.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOD_General.Vistas.Taller.Equipos
{
    public partial class VisualizarMarcas : Form
    {
        BrandController brandController = new BrandController();

        public VisualizarMarcas()
        {
            InitializeComponent();
        }

        private void VisualizarMarcas_Load(object sender, EventArgs e)
        {
            llenargrid();
        }

        public void llenargrid()
        {
            List<Brand> brandlist = new List<Brand>();
            brandlist = brandController.ViewBrand();

            foreach (var list in brandlist)
            {
                cR_DataGriedView1.Rows.Add(list.IdBrand, list._Brand, list._Enabled);
            }
        }
    }
}

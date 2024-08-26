using Modelos.Control_de_usuarios;
using Modelos.Taller;
using SOD_General.Controladores;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SOD_General.Vistas.Taller.Equipos
{
    public partial class VisualizarMarcas : Form
    {
        BrandController brandController = new BrandController();
        SizesGenerales _size = new SizesGenerales();
        Model_User user = Application.OpenForms.OfType<AppVistaGeneral>().First().user;
        public VisualizarMarcas()
        {
            InitializeComponent();
        }

        private void VisualizarMarcas_Load(object sender, EventArgs e)
        {
            llenargrid();
            ValidarAddMarcas();
            CentrarElemento();
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
        public void CentrarElemento()
        {
            Point SubL = cR_Subtitulos1.Location;
            cR_Subtitulos1.Location = _size.CentrarElementosX(SubL, cR_Subtitulos1.Size, this.Size);

            //Size panel = new Size(cR_SplitContainer1.Width, (cR_SplitContainer1.Height - cR_SplitContainer1.SplitterDistance));
            //panel1.Location = _size.CentrarElementosXY(panel1.Size, panel);
        }

        private void ValidarAddMarcas()
        {
            if (user.Confirm_Operation("Añadir Marcas"))
            {
                BtnAgregarMarcas.Visible = true;
            }
            else
            {
                BtnAgregarMarcas.Visible = false;
            }
        }

        private void BtnAgregarMarcas_Click(object sender, EventArgs e)
        {
            var formu = Application.OpenForms.OfType<AgregarMarcas>().FirstOrDefault();
            if (formu != null)
            {
                formu.Close();
            }
            AgregarMarcas addMarca = new AgregarMarcas();
            addMarca.Show();
        }
    }
}

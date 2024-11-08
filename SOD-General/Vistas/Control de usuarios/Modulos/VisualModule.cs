using Modelos.Control_de_usuarios;
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

namespace SOD_General.Vistas.Control_de_usuarios.Modulos
{
    public partial class VisualModule : Form
    {

        SizesGenerales _size = new SizesGenerales();
        Control_UsersController Control_UsersController = new Control_UsersController();
        List<Model_Module> modules = new List<Model_Module>();
        public VisualModule()
        {
            InitializeComponent();
            CentrarElementos();

        }

        public void Load_DataGriedView()
        {
            modules = Control_UsersController.Get_Modules();
            modules = modules.OrderBy(a => a._Module).ToList();
            if (modules != null)
            {
                foreach (Model_Module module in modules)
                {
                    cR_DataGriedView1.Rows.Add(
                        module.Id_Module,
                        module._Module
                        );
                }
            }
        }

        private void cR_SplitContainer1_Panel1_Resize(object sender, EventArgs e)
        {
            CentrarElementos();
        }

        public void CentrarElementos()
        {
            Point localA = cR_Subtitulos1.Location;
            cR_Subtitulos1.Location = _size.CentrarElementosX(localA, cR_Subtitulos1.Size, this.Size);
        }

        private void VisualModule_Load(object sender, EventArgs e)
        {
            Load_DataGriedView();
        }

        private void VisualModule_Resize(object sender, EventArgs e)
        {
            CentrarElementos();
        }
    }
}

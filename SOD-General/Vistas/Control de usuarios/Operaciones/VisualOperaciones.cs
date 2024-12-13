using DocumentFormat.OpenXml.Spreadsheet;
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

namespace SOD_General.Vistas.Control_de_usuarios.Operaciones
{
    public partial class VisualOperations : Form
    {
        SizesGenerales _size = new SizesGenerales();
        Control_UsersController Control_UsersController = new Control_UsersController();
        List<Model_Operations> operations = new List<Model_Operations>();
        List<Model_Module> modules = new List<Model_Module>();
        public VisualOperations()
        {
            InitializeComponent();
            CentrarElementos();
        }

        public void Load_DataGriedView()
        {
            cR_DataGriedView1.Rows.Clear();
            operations = Control_UsersController.Get_Operations();
            operations = operations.OrderBy(a => a._Module).ToList();
            if (operations != null)
            {
                foreach (Model_Operations op in operations)
                {
                    cR_DataGriedView1.Rows.Add(
                        op.Id_Operation,
                        op._Operation,
                        op._Module
                        );
                }
            }
        }

        public void Load_DataGriedView(List<Model_Operations> list)
        {
            cR_DataGriedView1.Rows.Clear();
            list = list.OrderBy(a => a._Module).ToList();
            if (operations != null)
            {
                foreach (Model_Operations op in list)
                {
                    cR_DataGriedView1.Rows.Add(
                        op.Id_Operation,
                        op._Operation,
                        op._Module
                        );
                }
            }
        }

        private void Load_Combobox()
        {
            modules = Control_UsersController.Get_Modules();
            if (modules != null)
            {
                cr_ComboBox2.Items.Add("Todas las operaciones");
                foreach (Model_Module role in modules)
                {
                    cr_ComboBox2.Items.Add(role._Module);
                }
            }
        }

        private void ChangeRoleComboBox()
        {
            var list = operations;
            string module = cr_ComboBox2.SelectedItem.ToString();
            if(module != "Todas las operaciones")
            {
                list = operations.Where(a => a._Module == module).ToList();
            }
            
            Load_DataGriedView(list);
        }

        public void CentrarElementos()
        {
            Point localA = cR_Subtitulos1.Location;
            cR_Subtitulos1.Location = _size.CentrarElementosX(localA, cR_Subtitulos1.Size, this.Size);
        }

        private void cR_SplitContainer1_Panel1_Resize(object sender, EventArgs e)
        {
            CentrarElementos();
        }

        

        private void VisualOperaciones_Load(object sender, EventArgs e)
        {
            Load_DataGriedView();
            Load_Combobox();
        }

        private void cr_ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeRoleComboBox();
        }
    }
}

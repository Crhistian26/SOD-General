using Modelos.Usuarios_Empleados;
using SOD_General.Controladores;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq.Expressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SOD_General.Vistas.Recursos_Humanos.Empleados
{
    public partial class AgregarEditar_Empleados : Form
    {
        SizesGenerales _size = new SizesGenerales();
        Registros_Controller controlRegistros = new Registros_Controller();
        List<Department> departamentos;
        public AgregarEditar_Empleados()
        {
            InitializeComponent();
            cR_Subtitulos1.Text = "Agregar empleado";
            botones_Nuevos1.Text = "Agregar";
            departamentos = controlRegistros.Obtener_Departamentos();
        }

        public AgregarEditar_Empleados(int? y)
        {
            InitializeComponent();
            cR_Subtitulos1.Text = "Editar empleado";
            botones_Nuevos1.Text = "Editar";
            panel2.Visible = true;
        }

        public AgregarEditar_Empleados(string y)
        {
            InitializeComponent();
            cR_Subtitulos1.Text = "Editar empleado";
            botones_Nuevos1.Text = "Editar";
            panel2.Visible = true;
            panel3.Visible = true;
        }
        private void CentrarElementos()
        {
            Point SubL = cR_Subtitulos1.Location;
            cR_Subtitulos1.Location = _size.CentrarElementosX(SubL, cR_Subtitulos1.Size, this.Size);

            Size panel = new Size(cR_SplitContainer1.Width, (cR_SplitContainer1.Height - cR_SplitContainer1.SplitterDistance));
            panel1.Location = _size.CentrarElementosXY(panel1.Size, panel);
        }

        private void LlenarComboDepartamentos()
        {
            foreach (Department depa in departamentos)
            {
                soD_ComboBox2.Items.Add(depa._Department);
            }
        }


        private void AgregarEditar_Empleados_Load(object sender, EventArgs e)
        {
            CentrarElementos();
            LlenarComboDepartamentos();
        }

        private void AgregarEditar_Empleados_Resize(object sender, EventArgs e)
        {
            CentrarElementos();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

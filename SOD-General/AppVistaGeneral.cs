using Controladores;
using Modelos.Usuarios_Empleados;
using SOD_General.Controladores;
using SOD_General.Recursos_Humanos.Empleados;
using SOD_General.Vistas_Taller.Taller_Recepcion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOD_General
{
    public partial class AppVistaGeneral : Form
    {
        /// <summary>
        /// atributo Controller de tipo VisGenContr que guardara una instancia del controlador 
        /// </summary>
        VistaGeneralController controller;

        SizesGenerales _size = new SizesGenerales();
        //La lista de autorizaciones.
        List<MAuthorization> authorizations = new List<MAuthorization>();

        //El departamento para la demostracion.
        /// <summary>
        /// atributo para almacenar lo departamentos
        /// </summary>
        public string Departamento;

        public Form formu;
        //El constructor que captura la lista y la llena.
        /// <summary>
        /// Constructor de la clase ApViGe, que acepta como parametro un string y luego ese param llenara el atributo definido 
        /// antes y le pasa al atributo Controller una nueva instancia del controlador y aeste le pasa una instancia de si mismo
        /// </summary>
        /// <param name="Departamento"></param>
        public AppVistaGeneral(List<MAuthorization> authorizations)
        {
            InitializeComponent();
            this.authorizations = authorizations;
            this.controller = new VistaGeneralController(this);
        }

        //La aplicacion cargando.
        private void AppVistaGeneral_Load(object sender, EventArgs e)
        {
            controller.Comprobar_Autorizaciones();
        }

        public void AbrirFormulario(Form formulario)
        {
            if (this.panel1.Controls.Count > 0)
            {
                panel1.Controls.Clear();
                panel1.Tag = null;
            }

            Form formula = formulario;
            formula.TopLevel = false;
            formula.Dock = DockStyle.Fill;
            this.formu = formula;
            this.panel1.Controls.Add(this.formu);
            this.panel1.Tag = this.formu;
            this.MinimumSize = formu.MinimumSize;
            this.formu.Show();

        }




        private void AppVistaGeneral_Resize(object sender, EventArgs e)
        {
            pictureBox1.Location = _size.CentrarElementosXY(pictureBox1.Size, panel1.Size);

        }
    }
}


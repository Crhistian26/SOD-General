using Controladores;
using Modelos.Usuarios_Empleados.Control_de_usuario;
using SOD_General.Controladores;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SOD_General
{
    public partial class AppVistaGeneral : Form
    {
        /// <summary>
        /// atributo Controller de tipo VisGenContr que guardara una instancia del controlador 
        /// </summary>
        ControlOperaciones controller;

        SizesGenerales _size = new SizesGenerales();
        //La lista de autorizaciones.
        public List<C_Operation> operations = new List<C_Operation>();



        //El departamento para la demostracion.
        /// <summary>
        /// atributo para almacenar lo departamentos
        /// </summary>

        public Form formu;
        //El constructor que captura la lista y la llena.
        /// <summary>
        /// Constructor de la clase ApViGe, que acepta como parametro un string y luego ese param llenara el atributo definido 
        /// antes y le pasa al atributo Controller una nueva instancia del controlador y aeste le pasa una instancia de si mismo
        /// </summary>
        /// <param name="Departamento"></param>
        public AppVistaGeneral(List<C_Operation> operations)
        {
            InitializeComponent();
            this.operations = operations;
            controller = new ControlOperaciones(this);
        }

        //La aplicacion cargando.
        private void AppVistaGeneral_Load(object sender, EventArgs e)
        {
            controller.Agregar_Items();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}


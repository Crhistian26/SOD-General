using Controladores;
using Modelos.Usuarios_Empleados;
using Modelos.Usuarios_Empleados.Control_de_usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOD_General
{
    public partial class VistaPrincipal : Form
    {
       /// <summary>
       /// atributo del form AppVistaGeneral (se hacen validaciones de autorizacion y demas)
       /// </summary>
        private AppVistaGeneral _appVistaGeneral;

        private Form formu;
        public VistaPrincipal()
        {
            InitializeComponent();
        }

        //Cuando el formulario se carga aca me cambia su diseño y lo primero que me abre es el login.
       /// <summary>
       /// carga los estilos para que el primer formulario se adapte y presente el login
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void VistaPrincipal_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;

            AbrirFormulario(new Login(this));
            this.Size = new Size(463, 284);

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        //La funcion que se encarga de abrirme los formularios.
        /// <summary>
        /// metodo que le da estilos al form que reciba como parametro
        /// </summary>
        /// <param name="formulario"></param>
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

        //Este es un metodo que me abrira la vista general y le enviara sus autorizaciones.
        //Esta se ejecutara desde el Login no desde aqui.
        //public void AbrirVistaGeneral(List<MAuthorization> autorizaciones)
        //{
        //    this.FormBorderStyle = FormBorderStyle.Sizable;
        //    this.WindowState = FormWindowState.Maximized;

        //    _appVistaGeneral = new AppVistaGeneral(autorizaciones);
            
        //    AbrirFormulario(_appVistaGeneral);
        //}

        
        public void AbrirVistaGeneral(List<C_Operation> operations)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Maximized;

            _appVistaGeneral = new AppVistaGeneral(operations);

            AbrirFormulario(_appVistaGeneral);
        }
        private void VistaPrincipal_Resize(object sender, EventArgs e)
        {
            this.formu.Size = panel1.Size;
            AbrirFormulario(formu);
        }
    }
}

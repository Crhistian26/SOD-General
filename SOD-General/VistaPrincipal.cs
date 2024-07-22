using Controladores;
using Modelos.Usuarios_Empleados;
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
       
        private AppVistaGeneral _appVistaGeneral;

        public VistaPrincipal()
        {
            InitializeComponent();
        }

        //Cuando el formulario se carga aca me cambia su diseño y lo primero que me abre es el login.
        private void VistaPrincipal_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            AbrirFormulario(new Login(this));
            this.Size = new Size(463, 284);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        //La funcion que se encarga de abrirme los formularios.
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
            this.panel1.Controls.Add(formula);
            this.panel1.Tag = formula;
            formula.Show();
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

        public void AbrirVistaGeneral(string hola)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Maximized;

            _appVistaGeneral = new AppVistaGeneral(hola);

            AbrirFormulario(_appVistaGeneral);
        }
        private void VistaPrincipal_Resize(object sender, EventArgs e)
        {
            if (_appVistaGeneral != null)
            {
                _appVistaGeneral.Size = panel1.Size;
            }
            
        }
    }
}

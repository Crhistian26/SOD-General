using Modelos.Control_de_usuarios;
using Modelos.Usuarios_Empleados.Control_de_usuario;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SOD_General
{
    public partial class VistaPrincipal : Form
    {

        private AppVistaGeneral _appVistaGeneral;
        private Form formu;
        public VistaPrincipal()
        {
            InitializeComponent();
        }

        private void VistaPrincipal_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;

            AbrirFormulario(new Login(this));
            this.Size = new Size(463, 284);

            this.StartPosition = FormStartPosition.CenterScreen;
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

     
        public void AbrirVistaGeneral(Model_User  user)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Maximized;

            _appVistaGeneral = new AppVistaGeneral(user);

            AbrirFormulario(_appVistaGeneral);
        }

        private void VistaPrincipal_Resize(object sender, EventArgs e)
        {
            this.formu.Size = panel1.Size;
            AbrirFormulario(formu);
        }
    }
}

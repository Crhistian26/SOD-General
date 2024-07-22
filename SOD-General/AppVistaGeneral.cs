using Controladores;
using Modelos.Usuarios_Empleados;
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
        VistaGeneralController controller = new VistaGeneralController();
        //La lista de autorizaciones.
        List<MAuthorization> authorizations = new List<MAuthorization>();

        //El departamento para la demostracion.
        string Departamento;

        //El constructor que captura la lista y la llena.
        public AppVistaGeneral(string Departamento)
        {
            InitializeComponent();
            this.Departamento = Departamento;
        }

        //La aplicacion cargando.
        private void AppVistaGeneral_Load(object sender, EventArgs e)
        {
            ToolStripMenuItem item = controller.Comprobar_Autorizaciones(cR_MenuStrip1, Departamento);
            cR_MenuStrip1.Items.Add(item);
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
            this.panel1.Controls.Add(formula);
            this.panel1.Tag = formula;
            formula.Show();
        }

    }
}

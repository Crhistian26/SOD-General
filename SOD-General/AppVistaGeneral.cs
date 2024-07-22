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

        //La lista de autorizaciones.
        List<MAuthorization> authorizations = new List<MAuthorization>();

        //El constructor que captura la lista y la llena.
        public AppVistaGeneral(List<MAuthorization> authorizations)
        {
            InitializeComponent();
            this.authorizations = authorizations;
        }

        //La aplicacion cargando.
        private void AppVistaGeneral_Load(object sender, EventArgs e)
        {
            
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

        public event EventHandler ReajustarSize;

        private void holaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void hoalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Visual_Empleados());
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

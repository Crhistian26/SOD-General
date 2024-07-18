using Controladores;
using Modelos.Usuarios_Empleados;
using SOD_General.Vistas_Taller.Taller_Recepcion;
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
    public partial class AppVistaGeneral : Form
    {
        List<MAuthorization> authorizations = new List<MAuthorization>();
        VistaGeneralController control = new VistaGeneralController();
        public AppVistaGeneral( List<MAuthorization> authorizations)
        {
            InitializeComponent();
            this.authorizations = authorizations;
        }

        private void AppVistaGeneral_Load(object sender, EventArgs e)
        {
            
            foreach (MAuthorization auth in authorizations)
            {
                MessageBox.Show(auth._Authorization);
            }
            control.Permisos(authorizations, this.menuStrip1);
        }

        private void hola(object sender, EventArgs e)
        {
            MessageBox.Show("funicon");
        }
        public void AbrirFormulario(Form formulario)
        {
            MessageBox.Show("hola");
            MessageBox.Show("mi prota");

            if (this.panel1.Controls.Count > 0)
            {
                panel1.Controls.Clear();
                panel1.Tag = null;
            }

            Form formula = formulario;
            formula.TopLevel = false;
            formula.Dock = DockStyle.Fill;
            formula.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(formula);
            this.panel1.Tag = formula;
            formula.Show();

        }

        private void verPeticionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new VisualizarPeticiones());
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

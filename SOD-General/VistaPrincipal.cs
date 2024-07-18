using Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        public VistaPrincipal()
        {
            InitializeComponent();
            
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

        public void AbrirVistaGeneral(AppVistaGeneral formulario)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Maximized;
            AbrirFormulario(formulario);
        }

        private void VistaPrincipal_Load(object sender, EventArgs e)
        {

            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            AbrirFormulario(new Login(this));
            this.Size = new Size(463, 284);

        }
        
    }
}

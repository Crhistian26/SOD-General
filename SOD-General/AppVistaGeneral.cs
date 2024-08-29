using Controladores;
using Modelos.Control_de_usuarios;
using SOD_General.Controladores;
using System;
using System.Windows.Forms;

namespace SOD_General
{
    public partial class AppVistaGeneral : Form
    {
        ControlOperaciones controller;
        SizesGenerales _size = new SizesGenerales();
        public Model_User user;

        public Form formu;
        public AppVistaGeneral(Model_User user)
        {
            InitializeComponent();

            this.user = user;
            controller = new ControlOperaciones(user, this);
        }

        private void AppVistaGeneral_Load(object sender, EventArgs e)
        {
            controller.AddItemsInMenustrip();
        }

        public void OpenForm(Form formulario)
        {
            if (this.panel1.Controls.Count > 0)
            {
                panel1.Controls.Clear();
                panel1.Tag = null;
            }
            if (panel1.Controls.Contains(formulario))
            {
                return;
            }

            Form formula = formulario;
            formula.TopLevel = false;
            formula.Dock = DockStyle.Fill;
            this.formu = formula;

            this.panel1.Controls.Add(this.formu);
            this.panel1.Tag = formula;
            this.MinimumSize = formu.MinimumSize;
            this.formu.Show();
        }

        private void AppVistaGeneral_Resize(object sender, EventArgs e)
        {
            pictureBox1.Location = _size.CentrarElementosXY(pictureBox1.Size, panel1.Size);
        }
    }
}


using Modelos.Control_de_usuarios;
using Modelos.Usuarios_Empleados.Control_de_usuario;
using SOD_General.Controladores;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SOD_General.Taller.Control_calidad
{
    public partial class VisualizarControles : Form
    {
        SizesGenerales _size = new SizesGenerales();
        Model_User user = Application.OpenForms.OfType<AppVistaGeneral>().First().user;
        public VisualizarControles()
        {
            InitializeComponent();
        }

        private void fR_SubTitulo1_Load(object sender, EventArgs e)
        {

        }

        public void CentrarElemento()
        {
            Point SubL = cR_Subtitulos1.Location;
            cR_Subtitulos1.Location = _size.CentrarElementosX(SubL, cR_Subtitulos1.Size, this.Size);

            //Size panel = new Size(cR_SplitContainer1.Width, (cR_SplitContainer1.Height - cR_SplitContainer1.SplitterDistance));
            //panel1.Location = _size.CentrarElementosXY(panel1.Size, panel);
        }

        private void ValidarAddEquip()
        {
            if (user.Confirm_Operation("Añadir Controles"))
            {
                btnControlAgregar.Visible = true;
            }
            else
            {
                btnControlAgregar.Visible = false;
            }
        }

        private void btnControlAgregar_Click(object sender, EventArgs e)
        {
            AgregarControles addControles = new AgregarControles();
            addControles.Show();
        }
    }
}

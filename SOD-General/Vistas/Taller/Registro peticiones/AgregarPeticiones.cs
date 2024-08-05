using SOD_General.Controladores;
using SOD_General.Recursos_Humanos.Empleados;
using SOD_General.Vistas.Taller.Registro_peticiones;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SOD_General.Taller.Registro_peticiones
{
    public partial class AgregarPeticiones : Form
    {
        SizesGenerales _size = new SizesGenerales();
        AppVistaGeneral vista;
        public AgregarPeticiones(AppVistaGeneral vista)
        {
            InitializeComponent();
            soD_ComboBox1.Items.Add("Pedro");
            this.vista = vista;
        }
        private void CentrarElementos()
        {
            Point SubL = cR_Subtitulos4.Location;
            cR_Subtitulos4.Location = _size.CentrarElementosX(SubL, cR_Subtitulos4.Size, this.Size);

            Size panel = new Size(cR_SplitContainer1.Width, (cR_SplitContainer1.Height - cR_SplitContainer1.SplitterDistance));
            panel1.Location = _size.CentrarElementosXY(panel1.Size, panel);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AgregarPeticiones_Load(object sender, EventArgs e)
        {
            CentrarElementos();
        }

        private void botones_Nuevos1_Click(object sender, EventArgs e)
        {
            RegistrarSolicitudEquipo regi = new RegistrarSolicitudEquipo(vista);
            vista.AbrirFormulario(regi);
        }

        private void AgregarPeticiones_Resize(object sender, EventArgs e)
        {
            CentrarElementos();
        }

        
    }
}

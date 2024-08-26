using Modelos.AsistenciasYPermisos;
using SOD_General.Controladores;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SOD_General.Vistas.Recursos_Humanos.Motivos
{
    public partial class AgregarEditar_Motivos : Form
    {
        SizesGenerales _size = new SizesGenerales();
        Motivos_Controller control = new Motivos_Controller();
        Model_Reason reason;
        public AgregarEditar_Motivos()
        {
            InitializeComponent();
            cR_Subtitulos1.Text = "Agregar motivo";
            botones_Nuevos1.Text = "Agregar";
            soD_ComboBox4.Visible = false;
            cR_LabelDown4.Visible = false;
            botones_Nuevos1.Click += AgregarBoton;
        }
        public AgregarEditar_Motivos(Model_Reason reason)
        {
            InitializeComponent();
            this.reason = reason;
            cR_Subtitulos1.Text = "Editar motivo";
            botones_Nuevos1.Text = "Editar";
            botones_Nuevos1.Click += EditarBoton;

            soD_TextBox1.Text = reason._Reason;
            soD_TextBox2.Text = reason._Descripcion;
            soD_ComboBox3.SelectedIndex = soD_ComboBox3.FindString(reason.MesureMaximune_Time);
            soD_ComboBox4.SelectedIndex = soD_ComboBox4.FindString(reason.For_mesure);
            CheckElements();
            cR_TextBoxNumerico1.Text = reason.MaximuneCount_Time.ToString();
        }

        private void CentrarElementos()
        {
            Point SubL = cR_Subtitulos1.Location;
            cR_Subtitulos1.Location = _size.CentrarElementosX(SubL, cR_Subtitulos1.Size, this.Size);

            Size panel = new Size(cR_SplitContainer1.Width, (cR_SplitContainer1.Height - cR_SplitContainer1.SplitterDistance));
            panel1.Location = _size.CentrarElementosXY(panel1.Size, panel);
        }


        private void AgregarEditar_Motivos_Load(object sender, EventArgs e)
        {
            CentrarElementos();

        }

        private string MesureValue()
        {
            string MesureFor = "";
            if (soD_ComboBox3.SelectedIndex == 3)
            {
                MesureFor = "Sin limites";
            }
            else if (soD_ComboBox3.SelectedIndex == 4)
            {
                MesureFor = "Unico";
            }
            else
            {
                MesureFor = soD_ComboBox4.SelectedItem.ToString();
            }
            return MesureFor;
        }
        private void AgregarBoton(object sender, EventArgs e)
        {
            Model_Reason reason = new Model_Reason
            (
                0,
                soD_TextBox1.Text,
                soD_TextBox2.Text,
                Convert.ToInt32(cR_TextBoxNumerico1.Text),
                soD_ComboBox3.SelectedItem.ToString(),
                MesureValue()
            );
            if (control.AddReason(reason))
            {
                control.ResetVisualReasons();
                this.Close();
            }
        }

        private void EditarBoton(object sender, EventArgs e)
        {
            Model_Reason reason = new Model_Reason
            (
                this.reason.IdReason,
                soD_TextBox1.Text,
                soD_TextBox2.Text,
                Convert.ToInt32(cR_TextBoxNumerico1.Text),
                soD_ComboBox3.SelectedItem.ToString(),
                MesureValue()
            );
            if (control.EditReason(reason))
            {
                control.ResetVisualReasons();
                this.Close();
            }
        }

        private void CheckElements()
        {
            if (soD_ComboBox3.SelectedIndex == 3 || soD_ComboBox3.SelectedIndex == 4)
            {
                cR_TextBoxNumerico1.Text = "0";
                cR_TextBoxNumerico1.Enabled = false;
                soD_ComboBox4.Enabled = false;

                soD_ComboBox4.Visible = false;
                cR_LabelDown4.Visible = false;

            }
            else
            {
                cR_TextBoxNumerico1.Clear();
                cR_TextBoxNumerico1.Enabled = true;
                soD_ComboBox4.Enabled = true;
                soD_ComboBox4.Visible = true;
                cR_LabelDown4.Visible = true;
            }
        }

        private void AgregarEditar_Motivos_Resize(object sender, EventArgs e)
        {
            CentrarElementos();
        }

        private void soD_ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckElements();
        }

        private void soD_ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

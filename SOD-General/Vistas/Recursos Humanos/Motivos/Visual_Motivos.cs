using Modelos.AsistenciasYPermisos;
using Modelos.Control_de_usuarios;
using Modelos.Taller;
using SOD_General.Controladores;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SOD_General.Vistas.Recursos_Humanos.Motivos
{
    public partial class Visual_Motivos : Form
    {
        SizesGenerales _size = new SizesGenerales();
        Motivos_Controller control = new Motivos_Controller();
        Model_User user = Application.OpenForms.OfType<AppVistaGeneral>().First().user;
        List<Model_Reason> reasons;
        public Visual_Motivos()
        {
            InitializeComponent();
            reasons = control.Obtener_Razones();
        }
        private void LlenarDataGried()
        {
            foreach (Model_Reason reason in reasons)
            {
                if(reason.MaximuneCount_Time != 0)
                {
                    cR_DataGriedView1.Rows.Add
                   (
                       reason.IdReason,
                       reason._Reason,
                       reason._Descripcion,
                       reason.MaximuneCount_Time + " " + reason.MesureMaximune_Time,
                       reason.For_mesure
                   );
                }
                else
                {
                    cR_DataGriedView1.Rows.Add
                   (
                       reason.IdReason,
                       reason._Reason,
                       reason._Descripcion,
                       reason.MesureMaximune_Time,
                       reason.For_mesure
                   );
                }
               
            }
        }

        private void Visual_Motivos_Load(object sender, EventArgs e)
        {
            Point punto = cR_Subtitulos1.Location;
            cR_Subtitulos1.Location = _size.CentrarElementosX(punto, cR_Subtitulos1.Size, this.Size);

            punto = botones_Nuevos1.Location;
            botones_Nuevos1.Location = _size.CentrarElementosX(punto, botones_Nuevos1.Size, this.Size);

            LlenarDataGried();

            if(user.Confirm_Operation("Agregar motivos"))
            {
                botones_Nuevos1.Visible = true;
            }
            else
            {
                botones_Nuevos1.Visible = false;
            }
            
        }

        private void Visual_Motivos_Resize(object sender, EventArgs e)
        {
            Point punto = cR_Subtitulos1.Location;
            cR_Subtitulos1.Location = _size.CentrarElementosX(punto, cR_Subtitulos1.Size, this.Size);

            punto = botones_Nuevos1.Location;
            botones_Nuevos1.Location = _size.CentrarElementosX(punto, botones_Nuevos1.Size, this.Size);
        }

        private void botones_Nuevos1_Click(object sender, EventArgs e)
        {

            control.OpenControlReasons();
        }

        private void cR_DataGriedView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if(user.Confirm_Operation("Editar motivos"))
                {
                    int id = Convert.ToInt32(cR_DataGriedView1.Rows[e.RowIndex].Cells[0].Value);
                    Model_Reason reason = reasons.Where(a => a.IdReason == id).Select(a => a).First();
                    control.OpenControlReasons(reason);
                }
            }
        }
    }
}

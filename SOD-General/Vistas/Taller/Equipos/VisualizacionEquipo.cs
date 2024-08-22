using Modelos.Control_de_usuarios;
using Modelos.Taller;
using SOD_General.Controladores;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SOD_General.Vistas.Taller.Equipos
{
    public partial class VisualizacionEquipo : Form
    {
        EquipmentController equipControl = new EquipmentController();
        SizesGenerales _size = new SizesGenerales();
        AppVistaGeneral vista;
        Model_User user = Application.OpenForms.OfType<AppVistaGeneral>().First().user;


        public VisualizacionEquipo()
        {
            InitializeComponent();
        }

        private void VisualizacionEquipo_Load(object sender, System.EventArgs e)
        {
            LlenarDataGridView();
            CentrarElemento();
            ValidarAddEquip();
        }

        private void LlenarDataGridView()
        {
            List<EquipType> TiposEquip = new List<EquipType>(); 
            TiposEquip = equipControl.visualizarEquipo();

            foreach (var tE in TiposEquip)
            {
                cR_DataGriedView1.Rows.Add(tE.IdEquipType, tE._EquipType, tE._Enabled);
            }
        }

        public void CentrarElemento()
        {
            Point SubL = cR_Subtitulos1.Location;
            cR_Subtitulos1.Location = _size.CentrarElementosX(SubL, cR_Subtitulos1.Size, this.Size);

            //Size panel = new Size(cR_SplitContainer1.Width, (cR_SplitContainer1.Height - cR_SplitContainer1.SplitterDistance));
            //panel1.Location = _size.CentrarElementosXY(panel1.Size, panel);
        }
        

        private void BtnAgregarEquip_Click(object sender, System.EventArgs e)
        {
            AgregarTipoEquipo addEquipo = new AgregarTipoEquipo();
            addEquipo.Show();
        }

        private void ValidarAddEquip()
        {
            if (user.Confirm_Operation("Añadir Equipo"))
            {
                BtnAgregarEquip.Visible = true;
            }
            else
            {
                BtnAgregarEquip.Visible = false;
            }
        }
    }
}

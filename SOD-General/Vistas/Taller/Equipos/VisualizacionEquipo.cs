using Modelos.Taller;
using SOD_General.Controladores;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SOD_General.Vistas.Taller.Equipos
{
    public partial class VisualizacionEquipo : Form
    {
        EquipmentController equipControl = new EquipmentController();

        public VisualizacionEquipo()
        {
            InitializeComponent();
        }

        private void VisualizacionEquipo_Load(object sender, System.EventArgs e)
        {
            LlenarDataGridView();
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
    }
}

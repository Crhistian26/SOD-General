using Modelos.Taller;
using SOD_General.Controladores;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SOD_General.Vistas.Taller.Control_calidad
{
    public partial class EnlaceControlEquipo : Form
    {
        QualityControlController qCC = new QualityControlController();
        public EnlaceControlEquipo()
        {

            InitializeComponent();
            qCC.ControlesCheckBx(FLPanel);
            llenarCombBox();
        }

        public void llenarCombBox()
        {
            List<EquipType> ctrlLis = new List<EquipType>();
            ctrlLis = qCC.RellenarCmbBox();

            foreach (var lista in ctrlLis)
            {
                cmbBx.Items.Add(lista._EquipType);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            qCC.agregarCheckbox(FLPanel, cmbBx);


        }

        private void cR_SplitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbBx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

using Modelos.Taller;
using SOD_General.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOD_General.Vistas.Taller.Control_calidad
{
    public partial class VerEnlace : Form
    {
        QualityControlController Qccller = new QualityControlController();
        public int id;
        public VerEnlace(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void VerEnlace_Load(object sender, EventArgs e)
        {
            List<Controles> ctrlQ = new List<Controles>();
            ctrlQ = Qccller.FiltrarControles(id);

            foreach (var ctrl in ctrlQ)
            {
                cR_DataGriedView1.Rows.Add(ctrl.idControl, ctrl.Name, ctrl.Enabled);
            }

        }
    }
}

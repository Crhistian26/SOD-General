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

namespace SOD_General.Vistas.Taller.Registro_peticiones
{
    public partial class AgregarAccesorios : Form
    {
        EquipmentController ControlEquipo = new EquipmentController();
        List<Accesories> accesorios = new List<Accesories>();

        public AgregarAccesorios()
        {
            InitializeComponent();
            llenarDgv();
        }


        public void llenarDgv()
        {
           accesorios = ControlEquipo.ObtenerAccesorios();

            foreach (var acces in accesorios)
            {
                dgvAccesorios.Rows.Add(acces.idAccesories, acces.nameAccesories, acces._Enable);
            }
        }

    }
}

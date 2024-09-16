using Modelos.Taller;
using SOD_General.Controladores;
using SOD_General.Vistas_Taller.Taller_Recepcion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SOD_General.Vistas.Taller.Registro_peticiones
{
    public partial class RegistrarSolicitudEquipo : Form
    {
        AppVistaGeneral vista;
        List<EquipType> TipoEquipo;
        List<Brand> marcas;
        List<Equipment> equipComp;

        int idTipo = 0;
        ClientController ClController = new ClientController();
        
        public RegistrarSolicitudEquipo()
        {
            InitializeComponent();
            this.vista = Application.OpenForms.OfType<AppVistaGeneral>().First();
 
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cR_DataGriedView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void botones_Nuevos2_Click(object sender, System.EventArgs e)
        {
            VisualizarPeticiones visuaPeti = new VisualizarPeticiones();
            MessageBox.Show("Orden registrada con todos los equipos del cliente");
            vista.OpenForm(visuaPeti);

        }

        private void botones_Nuevos1_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Equipo registrado en la tabla");
        }

        public void ObtenerTiposEquipos()
        {
            TipoEquipo = ClController.ObtenerTiposEquipos();

            foreach (var tipo in TipoEquipo)
            {
                cbTipoEquipo.Items.Add(tipo._EquipType);
            }
        }


        public void ObtenerMarcas()
        {
            marcas = ClController.ObtenerMarcas();
            foreach (var marc in marcas)
            {
                cbMarca.Items.Add(marc._Brand);
            }
        }

        

        public void llenarGrid()
        {

        }

        public void ObtenerModelo(int a)
        {
            List<NameEquipment> linea;
            linea = ClController.ObtenerLineaEquipo();

            if (linea != null)
            {
                List<NameEquipment> Lineacomp;
                Lineacomp = linea.Where(o => o.TypeEquipId == a)
                    .Select(e => e).ToList();

                cbLinea.Items.Clear();
                cbLinea.Text = null;

                foreach (var item in Lineacomp)
                {
                    cbLinea.Items.Add(item._NameEquipment);
                }
            }

            
        }

        private void RegistrarSolicitudEquipo_Load(object sender, System.EventArgs e)
        {
            ObtenerMarcas();
            ObtenerTiposEquipos();
            IdUltimo();
        }

        private void cbTipoEquipo_SelectedIndexChanged(object sender, System.EventArgs e)
        {

            if (cbTipoEquipo.SelectedItem != null)
            {
                string tipo = cbTipoEquipo.SelectedItem.ToString();

                idTipo = TipoEquipo.Where(q => q._EquipType == tipo).Select(l => l.IdEquipType).First();
                ObtenerModelo(idTipo);
            }

        }

        public void IdUltimo()
        {
           txtIdEntrada.Text = ClController.UltimoId().ToString();
        }
    }
}

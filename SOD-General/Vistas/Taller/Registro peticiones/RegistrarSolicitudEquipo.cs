using DocumentFormat.OpenXml.Drawing.Wordprocessing;
using Modelos.Taller;
using SOD_General.Controladores;
using SOD_General.Vistas_Taller.Taller_Recepcion;
using System;
using System.Collections.Generic;
using System.Globalization;
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
        List<NameEquipment> linea;
        List<DataEquip> datosEquipo;

        string marcaElegida;
        string tipo;
        string lineaElegida;
        string modelo;

        int idTipo = 0;
        int IdMarcas = 0;
        int IdLineas = 0;
        int idEquip = 0;
        int IdPetition;
        ClientController ClController = new ClientController();
        
        public RegistrarSolicitudEquipo(int idPeticion)
        {
            InitializeComponent();
            this.vista = Application.OpenForms.OfType<AppVistaGeneral>().First();
            this.IdPetition = idPeticion;
        }

        private void botones_Nuevos2_Click(object sender, System.EventArgs e)
        {
           
            if (cbTipoEquipo.SelectedItem != null && cbMarca.SelectedItem != null && cbLinea.SelectedItem != null && cbModelo.SelectedItem != null && txtSerial.Text != null && txtFalla.Text != null)
            {
               // ClController.AgregarEntradas(IdPetition, idEquipment, 1, txtSerial.Text, txtFalla.Text, buleano);
            }

            foreach (DataGridViewRow dgvr in dgvEquipoRegistro.Rows)
            {
                if (dgvr.IsNewRow)
                {
                 //   ClController.AgregarEntradas(IdPetition,Convert.ToInt32(dgvr.Cells[1].Value), 1, txtSerial.Text, txtFalla.Text, buleano);

                }
            }
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

        public void ObtenerLineas(int a)
        {
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
                tipo = cbTipoEquipo.SelectedItem.ToString();

                idTipo = TipoEquipo.Where(q => q._EquipType == tipo).Select(l => l.IdEquipType).First();
                ObtenerLineas(idTipo);
                
                ObtenerEquiposDgv(idTipo);
            }

        }

        public void IdUltimo()
        {
           txtIdEntrada.Text = ClController.UltimoId().ToString();
        }

        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMarca.SelectedItem != null)
            {
                marcaElegida = cbMarca.SelectedItem.ToString();
                IdMarcas = Convert.ToInt32(marcas.Where(a => a._Brand == marcaElegida).Select(b => b.IdBrand).First());

                ObtenerEquiposDgv(idTipo, IdMarcas);
            }
        }

        

        public void ObtenerEquiposDgv(int tipo)
        {
            dgvFiltro.Rows.Clear();
            datosEquipo  = ClController.DatosEquipo();
            List<DataEquip> equipCompData = new List<DataEquip>();

            equipCompData = datosEquipo.Where(o => o.tipoEquip.IdEquipType == tipo)
                  .Select(e => e).ToList();


            foreach (var item in equipCompData)
            {
                dgvFiltro.Rows.Add(item.equip.IdEquipment, item.tipoEquip._EquipType, item.marc._Brand, item.equip._Model);
            }
            
        }

        public void ObtenerEquiposDgv(int tipo, int marca)
        {
            dgvFiltro.Rows.Clear();
            datosEquipo = ClController.DatosEquipo();
            List<DataEquip> equipCompData = new List<DataEquip>();

            equipCompData = datosEquipo.Where(o => o.tipoEquip.IdEquipType == tipo)
                  .Select(e => e).ToList();

            List<DataEquip> equipCompData2 = new List<DataEquip>();
            equipCompData2 = equipCompData.Where(o => o.marc.IdBrand == marca)
                  .Select(e => e).ToList();


            foreach (var item in equipCompData2)
            {
                dgvFiltro.Rows.Add(item.equip.IdEquipment, item.tipoEquip._EquipType, item.marc._Brand, item.equip._Model);
            }

        }

        public void ObtenerEquiposDgv(int tipo, int marca, int linea )
        {
            dgvFiltro.Rows.Clear();
            datosEquipo = ClController.DatosEquipo();
            List<DataEquip> equipCompData = new List<DataEquip>();
            equipCompData = datosEquipo.Where(o => o.tipoEquip.IdEquipType == tipo)
                  .Select(e => e).ToList();

            List<DataEquip> equipCompData2 = new List<DataEquip>();
            equipCompData2 = equipCompData.Where(o => o.marc.IdBrand == marca)
                  .Select(e => e).ToList();

            List<DataEquip> equipCompData3 = new List<DataEquip>();
            equipCompData3 = equipCompData2.Where(o => o.equipoNomb.IdNameEquipment == linea)
                  .Select(e => e).ToList();


            foreach (var item in equipCompData3)
            {
                dgvFiltro.Rows.Add(item.equip.IdEquipment, item.tipoEquip._EquipType, item.marc._Brand, item.equip._Model);
            }

        }


        private void cbLinea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLinea.SelectedItem != null)
            {
                lineaElegida = cbLinea.SelectedItem.ToString();
                IdLineas = Convert.ToInt32(linea.Where(a => a._NameEquipment == lineaElegida).Select(b => b.IdNameEquipment).First());

                ObtenerModelos(IdLineas);
                ObtenerEquiposDgv(idTipo, IdMarcas, IdLineas);
            }
        }

        public void ObtenerModelos(int idlinea)
        {
            equipComp = ClController.ObtenerEquipo();

            List<Equipment> dataEquips = new List<Equipment>();
            dataEquips = equipComp.Where(u => u._Equip == idlinea).Select(o => o).ToList();

            cbModelo.Items.Clear();
            cbModelo.Text = null;

            foreach (var marc in dataEquips)
            {
                cbModelo.Items.Add(marc._Model);
            }
        }


        private void cbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            modelo = cbModelo.SelectedItem.ToString();

            idEquip = Convert.ToInt32(equipComp.Where(u => u._Model == modelo).Where(u => u.EquipTypeId == idTipo).Where(u => u.BrandID == IdMarcas).Where(u => u._Equip == idEquip).Select(o => o.IdEquipment).First());
        }

        private void btnAgregRegistro_Click(object sender, EventArgs e)
        {
            int idEquipment = Convert.ToInt32(equipComp.Where(a => a.EquipTypeId == idTipo).Where(a => a.BrandID == IdMarcas).Where(a => a._Equip == IdLineas).Where(a => a._Model == modelo).Select(b => b.IdEquipment).First());
            bool buleano = equipComp.Where(a => a.IdEquipment == idEquipment).Select(b => b._PrinterCheck).First();

            if (cbTipoEquipo.SelectedItem != null && cbMarca.SelectedItem != null && cbLinea.SelectedItem != null && cbModelo.SelectedItem != null && txtSerial.Text != null && txtFalla.Text != null)
            {
                dgvEquipoRegistro.Rows.Add(idEquipment.ToString(), cbTipoEquipo.SelectedItem.ToString(), cbMarca.SelectedItem.ToString(), cbLinea.SelectedItem.ToString(), cbModelo.SelectedItem.ToString(), txtSerial.Text.ToString(), txtFalla.Text.ToString());

                dgvFiltro.Rows.Clear();
                cbModelo.SelectedItem = null;
                cbLinea.SelectedItem = null;
                cbMarca.SelectedItem = null;
                cbTipoEquipo.SelectedItem = null;
                txtSerial.Text = null;
                txtFalla.Text = null;
            }
            else
            {
                MessageBox.Show("Faltan datos por ingresar, por favor, completelos");
            }
            
        }
    }
}

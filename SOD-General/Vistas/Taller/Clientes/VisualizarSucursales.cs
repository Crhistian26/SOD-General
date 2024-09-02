using Modelos.Taller;
using SOD_General.Controladores;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SOD_General.Vistas.Taller.Clientes
{
    public partial class VisualizarSucursales : Form
    {
        VisualizarClientes clientes = new VisualizarClientes();
        ClientController controllers = new ClientController();
        public int Id;
        public VisualizarSucursales(int id)
        {
            InitializeComponent();
            this.Id = id;
        }

        private void cR_SplitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VisualizarSucursales_Load(object sender, EventArgs e)
        {
            llenarGridSucursal();
        }

        private void llenarGridSucursal()
        {
            try
            {
                List<Locations> Location = new List<Locations>();
                Location = controllers.ViewLocation(Id);

                dgvSucursal.Rows.Clear();
                if (Location != null)
                {
                    foreach (Locations locat in Location)
                    {
                        dgvSucursal.Rows.Add(locat.IdLocation, locat.IdClient, locat._Location, locat.Addrees, locat.Phone1, locat.Phone2, locat.IdContact, locat.Identifier);
                    }
                }
                else
                {
                    MessageBox.Show("Este cliente no tiene sucursales registradas");
                    this.Close();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString());
            }
        }
    }
}

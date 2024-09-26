using DocumentFormat.OpenXml.Bibliography;
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
        EntryOrderController enOrController = new EntryOrderController();
        int i = 0;
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


        private void dgvAccesorios_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            //if (dgvAccesorios.CurrentCell is DataGridViewCheckBoxCell)
            //{
            //    dgvAccesorios.CommitEdit(DataGridViewDataErrorContexts.Commit);
            //}
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvr in dgvAccesorios.Rows)
            {
                if (!dgvr.IsNewRow)
                {
                    bool _Checked = Convert.ToBoolean(dgvr.Cells[3].Value);
                    if (_Checked == true)
                    {
                       enOrController.tomarEntradas(Convert.ToInt32(dgvr.Cells[0].Value));
                    }
                }
            };
            this.Close();

        }

        private void AgregarAccesorios_Load(object sender, EventArgs e)
        {
            estiloDgv(dgvAccesorios);
        }

        public void estiloDgv(DataGridView dgv)
        {
            // Configuración general del DataGridView
            dgv.BackgroundColor = System.Drawing.Color.White;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowDrop = false;
            dgv.EnableHeadersVisualStyles = false;
           // dgv.ReadOnly = true;  // Configura todo el DataGridView como solo lectura
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Crear el estilo para los encabezados de columna
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.Font = new Font("Microsoft YaHei", 10);  // Fuente para el encabezado
            columnHeaderStyle.ForeColor = System.Drawing.Color.White;  // Color de texto de encabezado
            columnHeaderStyle.BackColor = System.Drawing.Color.FromArgb(0, 153, 168);  // Color de fondo de encabezado
            dgv.ColumnHeadersDefaultCellStyle = columnHeaderStyle;  // Aplicar estilo al encabezado de las columnas
        }
    }
}

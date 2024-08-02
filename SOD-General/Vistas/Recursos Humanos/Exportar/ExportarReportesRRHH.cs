using Modelos.Usuarios_Empleados;
using SOD_General.Controladores;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SOD_General.Vistas.Recursos_Humanos.Exportar
{
    public partial class ExportarReportesRRHH : Form
    {
        SizesGenerales _size = new SizesGenerales();
        Registros_Controller controlRegistro = new Registros_Controller();
        List<Employee> empleados;
        public ExportarReportesRRHH()
        {
            InitializeComponent();
            empleados = controlRegistro.Obtener_Empleados();
        }

        private void LlenarComboEmpleados()
        {
            cr_ComboBox2.Items.Add("Todos los empleados");
            foreach (Employee emp in empleados)
            {
                cr_ComboBox2.Items.Add(emp._Name + " " + emp._Lastname);
            }
        }

        private void CentrarElementos()
        {
            Point SubL = cR_Subtitulos1.Location;
            cR_Subtitulos1.Location = _size.CentrarElementosX(SubL, cR_Subtitulos1.Size, this.Size);

            Size panel = new Size(cR_SplitContainer1.Width, (cR_SplitContainer1.Height - cR_SplitContainer1.SplitterDistance));
            panel1.Location = _size.CentrarElementosXY(panel1.Size, panel);
        }

        private void ExportarReportesRRHH_Resize(object sender, EventArgs e)
        {
            CentrarElementos();
        }

        private void ExportarReportesRRHH_Load(object sender, EventArgs e)
        {
            CentrarElementos();
        }
    }
}

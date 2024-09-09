using Modelos.Control_de_usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOD_General.Vistas.Control_de_usuarios.Operaciones
{
    public partial class ControlOperaciones : Form
    {
        Model_Operations Operation;
        List<Model_Module> Modules;
        public ControlOperaciones()
        {
            InitializeComponent();
            foreach(var module in Modules)
            {
                cr_ComboBox1.Items.Add(module._Module);
            }
            botones_Nuevos1.Text = "Agregar operacion";
            botones_Nuevos1.Click += Add_Operation;
        }

        public ControlOperaciones(Model_Operations ope)
        {
            InitializeComponent();
            Operation = ope;

            cr_Textbox1.Text = ope._Operation;
            panel2.Visible = true;
            cr_Textbox2.Text = ope._Module;
            botones_Nuevos1.Text = "Guardar cambios";
            botones_Nuevos1.Click += Edit_Operation;
        }

        private void ControlOperaciones_Load(object sender, EventArgs e)
        {

        }
        private void Add_Operation(object sender, EventArgs e)
        {

        }

        private void Edit_Operation(object sender, EventArgs e)
        {

        }
        
    }
}

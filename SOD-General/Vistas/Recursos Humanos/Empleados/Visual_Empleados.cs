using Controladores;
using Modelos.Control_de_usuarios;
using Modelos.Usuarios_Empleados;
using SOD_General.Controladores;
using SOD_General.Vistas.Recursos_Humanos.Empleados;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SOD_General.Recursos_Humanos.Empleados
{
    public partial class Visual_Empleados : Form
    {
        SizesGenerales _size = new SizesGenerales();

        Empleados_Controller controlEmpleados = new Empleados_Controller();
        Registros_Controller controlRegistros = new Registros_Controller();
        Model_User user = Application.OpenForms.OfType<AppVistaGeneral>().First().user;
        ControlOperaciones operaciones;

        List<Employee> Empleados;

        List<Department> departamentos;

        public Visual_Empleados()
        {
            InitializeComponent();
            //operaciones = new ControlOperaciones(app);
            departamentos = controlRegistros.Obtener_Departamentos();
        }

        public void Reset()
        {
            if (!user.Confirm_Operation("Agregar empleados"))
            {
                botones_Nuevos1.Visible = false;
            }
            Empleados = controlEmpleados.ListaGeneralEmpleados();
            CentrarElementos();
            LlenarDataGried();
            LlenarComboDepartamentos();
        }
        public void CentrarElementos()
        {
            Point localA = cR_Subtitulos1.Location;
            cR_Subtitulos1.Location = _size.CentrarElementosX(localA, cR_Subtitulos1.Size, this.Size);
        }

        public string JobState(Employee empleado)
        {
            if (empleado.Job_State)
            {
                return "Trabajando";
            }
            else
            {
                return "Despedido";
            }
        }

        public void LlenarDataGried()
        {
            cR_DataGriedView1.Rows.Clear();
            foreach (Employee empleado in Empleados)
            {
                int id = empleado.IdEmployee;
                string name = empleado._Name;
                string lastname = empleado._Lastname;
                string department = empleado.Department;
                DateTime date = empleado.Admission_date;
                cR_DataGriedView1.Rows.Add(id, name, lastname, department, date.ToString("D"), JobState(empleado));
            }
        }

        private void LlenarComboDepartamentos()
        {
            comboBox1.Items.Add("Todos los departamentos");
            foreach (Department depa in departamentos)
            {
                comboBox1.Items.Add(depa._Department);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void Visual_Empleados_Load(object sender, EventArgs e)
        {
            Reset();
        }

        public void OrganizarDataGriedDepartamento()
        {
            cR_DataGriedView1.Rows.Clear();
            if (comboBox1.Text != "Todos los departamentos")
            {
                cR_DataGriedView1.Rows.Clear();
                var data = Empleados.Select(a => a).Where(a => a.Department == comboBox1.Text).ToList();

                if (data.Count > 0)
                {
                    foreach (Employee empleado in data)
                    {
                        cR_DataGriedView1.Rows.Add(
                            empleado.IdEmployee,
                            empleado._Name,
                            empleado._Lastname,
                            empleado.Department,
                            empleado.Admission_date.ToString("D"),
                            JobState(empleado)
                        );
                    }
                }
            }
            else
            {
                LlenarDataGried();
            }
        }

        private void cR_DataGriedView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Junciona");
        }

        private void cR_DataGriedView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                var win = Application.OpenForms.OfType<Empleado_Details>().FirstOrDefault();
                if (win != null)
                {
                    win.Close();
                }

                DataGridViewRow fila = cR_DataGriedView1.Rows[e.RowIndex];
                int id = Convert.ToInt32(fila.Cells[0].Value);

                Empleado_Details vista = new Empleado_Details(id);
                vista.Show();
            }
        }

        private void cR_SplitContainer1_Panel1_Resize(object sender, EventArgs e)
        {
            CentrarElementos();
        }

        private void botones_Nuevos1_Click(object sender, EventArgs e)
        {
            controlEmpleados.Abrir_Control_Empleados();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrganizarDataGriedDepartamento();
        }
    }
}

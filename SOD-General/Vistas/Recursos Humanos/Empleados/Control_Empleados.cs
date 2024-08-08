using Modelos.Control_de_usuarios;
using Modelos.Usuarios_Empleados;
using SOD_General.Controladores;
using SOD_General.Recursos_Humanos.Empleados;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SOD_General.Vistas.Recursos_Humanos.Empleados
{
    public partial class Control_Empleados : Form
    {
        SizesGenerales _size = new SizesGenerales();
        Registros_Controller controlRegistros = new Registros_Controller();
        Empleados_Controller controlEmpleados = new Empleados_Controller();
        List<Department> departamentos;
        Visual_Empleados Padre;
        Model_User user = Application.OpenForms.OfType<AppVistaGeneral>().FirstOrDefault().user;
        Employee employee;
        public Control_Empleados()
        {
            InitializeComponent();
            cR_Subtitulos1.Text = "Agregar empleado";
            botones_Nuevos1.Text = "Agregar";
            departamentos = controlRegistros.Obtener_Departamentos();
            LlenarComboDepartamentos();
            botones_Nuevos1.Click += AddEmployee;
        }


        public Control_Empleados(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            departamentos = controlRegistros.Obtener_Departamentos();
            cR_Subtitulos1.Text = "Editar empleado";
            botones_Nuevos1.Text = "Editar";
            panel2.Visible = true;
            cR_DateTimePicker1.Value = employee.Admission_date;
            botones_Nuevos1.Click += EditEmployee;


            if (employee.Dismissal_date.HasValue)
            {
                panel3.Visible = true;
                cR_DateTimePicker2.Value = employee.Dismissal_date.Value;
                cR_DateTimePicker2.Enabled = false;
                cR_Checkbox1.Checked = false;
                cR_Checkbox2.Checked = true;
            }
            else
            {
                cR_Checkbox1.Checked = true;
                cR_Checkbox2.Checked = false;
            }
            soD_TextBox1.Text = employee._Name;
            soD_TextBox2.Text = employee._Lastname;
            LlenarComboDepartamentos();


            cR_ComboBox.SelectedIndex = cR_ComboBox.FindString(employee.Department);
        }

        
        private void CentrarElementos()
        {
            Point SubL = cR_Subtitulos1.Location;
            cR_Subtitulos1.Location = _size.CentrarElementosX(SubL, cR_Subtitulos1.Size, this.Size);

            Size panel = new Size(cR_SplitContainer1.Width, (cR_SplitContainer1.Height - cR_SplitContainer1.SplitterDistance));
            panel1.Location = _size.CentrarElementosXY(panel1.Size, panel);
        }

        private void LlenarComboDepartamentos()
        {
            foreach (Department depa in departamentos)
            {
                cR_ComboBox.Items.Add(depa._Department);
            }
        }


        private void AgregarEditar_Empleados_Load(object sender, EventArgs e)
        {
            if(user.Confirm_Operation("Eliminar empleados"))
            {
                botones_Nuevos2.Visible = false;
            }
            CentrarElementos();
        }

        private void AgregarEditar_Empleados_Resize(object sender, EventArgs e)
        {
            CentrarElementos();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cR_Checkbox1_CheckedChanged(object sender, EventArgs e)
        {
            if(cR_Checkbox1.Checked)
            {
                cR_Checkbox2.Checked = false;
            }
        }

        private void cR_Checkbox2_CheckedChanged(object sender, EventArgs e)
        {
            if (cR_Checkbox2.Checked)
            {
                cR_Checkbox1.Checked = false;
            }
        }

        private void AddEmployee(object sender, EventArgs e)
        {
            Employee emp = new Employee
                (
                    0,
                    departamentos[cR_ComboBox.SelectedIndex].IdDepartment,
                    departamentos[cR_ComboBox.SelectedIndex]._Department,
                    soD_TextBox1.Text,
                    soD_TextBox2.Text,
                    cR_DateTimePicker1.Value,
                    null,
                    true,
                    true
                );
            if(controlEmpleados.AddEmployee(emp))
            {
                controlEmpleados.Reset_VisualEmpleados();
                this.Close();
            }
        }
        private void EditEmployee(object sender, EventArgs e)
        {
            bool state = false;
            if(cR_Checkbox1.Checked)
            {
                state = true;
            }
            else
            {
                state = false;
            }
            Employee emp = new Employee
                (
                    employee.IdEmployee,
                    departamentos[cR_ComboBox.SelectedIndex].IdDepartment,
                    soD_TextBox1.Text,
                    soD_TextBox2.Text,
                    cR_DateTimePicker1.Value,
                    state
                );
            if (controlEmpleados.EditEmployee(emp))
            {
                controlEmpleados.Reset_VisualEmpleados();
                this.Close();
            }
        }

        private void botones_Nuevos2_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show("Eliminar el usuario hara que todos los registros de asistencias, permisos, y su usuario en el sistema sean eliminados, esta seguro de querer eliminar el empleado.", $"Eliminar el empleado: {employee._Name} {employee._Lastname}",MessageBoxButtons.OKCancel);
            if(message == DialogResult.OK)
            {
                if(controlEmpleados.DeleteEmployee(employee.IdEmployee))
                {
                    controlEmpleados.Reset_VisualEmpleados();
                    this.Close();
                }
            }
        }
    }
}

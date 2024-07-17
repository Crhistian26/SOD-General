using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Usuarios_Empleados
{
    public class Employee
    {
        public int IdEmployee { get; set; }
        public int DepartmentId { get; set; }
        public string _Name { get; set; }
        public string _Lastname { get; set; }
        public DateTime Admission_date { get; set; }
        public DateTime? Dismissal_date { get; set; }
        public bool _Enabled { get; set; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Employee"/>.
        /// </summary>
        /// <param name="idEmployee">ID del empleado.</param>
        /// <param name="departmentId">ID del departamento.</param>
        /// <param name="name">Nombre del empleado.</param>
        /// <param name="lastname">Apellido del empleado.</param>
        /// <param name="admissionDate">Fecha de admisión del empleado.</param>
        /// <param name="dismissalDate">Fecha de despido del empleado.</param>
        /// <param name="enabled">Estado de habilitación del empleado.</param>
        public Employee(int idEmployee, int departmentId, string name, string lastname, DateTime admissionDate, DateTime? dismissalDate, bool enabled)
        {
            IdEmployee = idEmployee;
            DepartmentId = departmentId;
            _Name = name;
            _Lastname = lastname;
            Admission_date = admissionDate;
            Dismissal_date = dismissalDate;
            _Enabled = enabled;
        }
    }
}

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
        public string Department { get; set; }
        public string _Name { get; set; }
        public string _Lastname { get; set; }
        public DateTime Admission_date { get; set; }
        public DateTime? Dismissal_date { get; set; }
        public bool _Enabled { get; set; }
        public bool Job_State { get; set; }

        public Employee(int IdEmployee,string Name,string Lastname, string Department, DateTime Admission_Date)
        {
            this.IdEmployee = IdEmployee;
            this._Name = Name;
            this._Lastname = Lastname;
            this.Department = Department;
            this.Admission_date = Admission_Date;
        }

        
    }
}

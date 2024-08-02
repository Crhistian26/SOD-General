using System;

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

        public Employee(int IdEmployee, string Name, string Lastname)
        {
            this.IdEmployee = IdEmployee;
            this._Name = Name;
            this._Lastname = Lastname;
        }

        public Employee(int IdEmployee, string Name, string Lastname, string Department, DateTime Admission_Date)
            :this(IdEmployee,Name,Lastname)
        {
            this.Admission_date = Admission_Date;
            this.Department = Department;

        }

        public Employee(int idEmployee, int departmentId, string department, string name, string lastname, DateTime admissionDate, DateTime? dismissalDate, bool enabled, bool jobState)
            : this(idEmployee, name, lastname, department, admissionDate)
        {
            DepartmentId = departmentId;
            Dismissal_date = dismissalDate;
            _Enabled = enabled;
            Job_State = jobState;
        }

    }
}

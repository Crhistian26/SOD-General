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
        //public Employee(int DepartmentId, string Name, string Lastname)
        //{

        //    this.DepartmentId = DepartmentId;
        //    this._Name = Name;
        //    this._Lastname = Lastname;
        //}

        //public Employee(int DepartmentId,string Department, string Name, string Lastname)
        //    :this(DepartmentId,Name,Lastname)
        //{
        //    this.Department = Department;
        //}

        //public Employee(int DepartmentId, string Department, string Name, string Lastname, DateTime Admission_Date)
        //    :this(DepartmentId,Department, Name, Lastname)
        //{
        //    this.Admission_date = Admission_Date;
        //}

        //public Employee(int DepartmentId, string Department, string Name, string Lastname, DateTime Admission_Date, DateTime? Dismissal_Date, bool Enabled, bool JobState)
        //    : this(DepartmentId, Department, Name, Lastname,Admission_Date)
        //{
        //    this.Dismissal_date = Dismissal_Date;
        //    this._Enabled = Enabled;
        //    this.Job_State = JobState;
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Usuarios_Empleados.Control_de_usuario
{
    public class C_Operation
    {
        public int? Id { get; set; }
        public int? Id_Module { get; set; }
        public string Module_Name { get; set; }
        public string _Operation { get; set; }

        public C_Operation(string _Operation, string Module_Name)
        {
            this._Operation = _Operation;
            this.Module_Name = Module_Name;
        }

        public C_Operation(int Id, string _Operation, string Module_Name)
            : this(_Operation, Module_Name)
        {
            this.Id = Id;
        }

        public C_Operation(int Id, int Id_Module, string _Operation, string Module_Name)
            : this(Id, _Operation, Module_Name)
        {
            this.Id_Module = Id_Module;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Control_de_usuarios
{
    public class Model_Role
    {
        public int Id_Role { get; set; }
        public string Name { get; set; }
        public List<Model_Operations> _Operations { get; set; }

        public Model_Role(int id,string name, List<Model_Operations> operations)
        {
            this.Id_Role = id;
            this.Name = name;
            this._Operations = operations;
        }
    }
}

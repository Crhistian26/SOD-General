using System.Collections.Generic;

namespace Modelos.Control_de_usuarios
{
    public class Model_Role
    {
        public int Id_Role { get; set; }
        public string Name { get; set; }
        public List<Model_Operations> _Operations { get; set; }

        public Model_Role(string name)
        {
            this.Name = name;
        }

        public Model_Role(int id, string name)
            : this(name)
        {
            this.Id_Role = id;
        }
        public Model_Role(int id, string name, List<Model_Operations> operations)
            : this(id,name)
        {
            this._Operations = operations;
        }
    }
}

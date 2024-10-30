using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Control_de_usuarios
{
    public class Model_Module
    {
        public int Id_Module { get; set; }
        public string _Module { get; set; }

        public Model_Module(int id, string module)
        {
            this.Id_Module = id;
            this._Module = module;
        }
    }
}

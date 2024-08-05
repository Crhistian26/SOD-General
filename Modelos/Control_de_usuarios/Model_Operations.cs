using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Control_de_usuario
{
    internal class Model_Operations
    {
        public int Id_Operation { get; set; }
        public string _Module {  get; set; }
        public string _Operation { get; set; }

        public Model_Operations(int id, string module, string operation) 
        {
            this.Id_Operation = id;
            this._Module = module;
            this._Operation = operation;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Taller
{
    public class Accesories
    {
        public int idAccesories {  get; set; }
        public string nameAccesories { get; set; }
        public bool _Enable {  get; set; }

        public Accesories(int idAccesories, string nameAccesories, bool _Enable)
        {
            this.idAccesories = idAccesories;
            this.nameAccesories = nameAccesories;
            this._Enable = _Enable;
        }
    }
}

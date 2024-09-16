using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Taller
{
    public class NameEquipment
    {
        public int IdNameEquipment { get; set; }
        public string _NameEquipment { get; set; }
        public bool _Enable { get; set; }
        public int TypeEquipId { get; set; }

        public NameEquipment(int id, string _name, bool enab, int typeEquipId)
        {
            this.IdNameEquipment = id;
            this._NameEquipment = _name;
            this._Enable = enab;
            this.TypeEquipId = typeEquipId;
        }
    }

   
}

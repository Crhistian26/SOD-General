using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Taller
{
    public class DataEquip
    {
        public Equipment equip { get; set; }
        public Brand marc { get; set; }
        public EquipType tipoEquip { get; set; }
        public NameEquipment equipoNomb { get; set; }



        public DataEquip(Equipment equip, Brand marc, EquipType tipoEquip, NameEquipment equipoNomb)
        {
            this.equip = equip;
            this.marc = marc;
            this.tipoEquip = tipoEquip;
            this.equipoNomb = equipoNomb;
        }
    }

   
}

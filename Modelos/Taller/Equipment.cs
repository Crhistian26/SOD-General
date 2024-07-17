using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Taller
{
    public class Equipment
    {
        public int IdEquipment { get; set; }
        public int BrandID { get; set; }
        public int EquipTypeId { get; set; }
        public string _Equip { get; set; }
        public string _Model { get; set; }
        public bool _PrinterCheck { get; set; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Equipment"/>.
        /// </summary>
        /// <param name="idEquipment">ID del equipo.</param>
        /// <param name="brandID">ID de la marca.</param>
        /// <param name="equipTypeId">ID del tipo de equipo.</param>
        /// <param name="equip">Nombre del equipo.</param>
        /// <param name="model">Modelo del equipo.</param>
        /// <param name="printerCheck">Si dispone de impresora.</param>
        public Equipment(int idEquipment, int brandID, int equipTypeId, string equip, string model, bool printerCheck)
        {
            IdEquipment = idEquipment;
            BrandID = brandID;
            EquipTypeId = equipTypeId;
            _Equip = equip;
            _Model = model;
            _PrinterCheck = printerCheck;
        }
    }
}

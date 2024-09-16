namespace Modelos.Taller
{
    public class Equipment
    {
        public int IdEquipment { get; set; }
        public int BrandID { get; set; }
        public int EquipTypeId { get; set; }
        public int _Equip { get; set; }
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
        public Equipment(int idEquipment, int brandID, int equipTypeId, string model, bool printerCheck, int equip)
        {
            this.IdEquipment = idEquipment;
            this.BrandID = brandID;
            this.EquipTypeId = equipTypeId;
            this._Model = model;
            this._PrinterCheck = printerCheck;
            this._Equip = equip;

        }
    }
}

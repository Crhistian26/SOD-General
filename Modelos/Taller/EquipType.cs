namespace Modelos.Taller
{
    public class EquipType
    {
        public int? IdEquipType { get; set; }
        public string _EquipType { get; set; }
        public bool _Enabled { get; set; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="EquipType"/>.
        /// </summary>
        /// <param name="idEquipType">ID del tipo de equipo.</param>
        /// <param name="equipType">Nombre del tipo de equipo.</param>
        /// <param name="enabled">Estado de habilitación del tipo de equipo.</param>
        public EquipType(int? idEquipType, string equipType, bool enabled)
        {
            IdEquipType = idEquipType;
            _EquipType = equipType;
            _Enabled = enabled;
        }
    }
}

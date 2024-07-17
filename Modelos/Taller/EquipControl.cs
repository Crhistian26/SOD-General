using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Taller
{
    public class EquipControl
    {
        public int IdEquipControl { get; set; }
        public int EquipTypeId { get; set; }
        public int ControlId { get; set; }
        public bool Enabled { get; set; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="EquipControl"/>.
        /// </summary>
        /// <param name="idEquipControl">ID del control de equipo.</param>
        /// <param name="equipTypeId">ID del tipo de equipo.</param>
        /// <param name="controlId">ID del control asociado.</param>
        /// <param name="enabled">Indica si el control de equipo está habilitado.</param>
        public EquipControl(int idEquipControl, int equipTypeId, int controlId, bool enabled)
        {
            IdEquipControl = idEquipControl;
            EquipTypeId = equipTypeId;
            ControlId = controlId;
            Enabled = enabled;
        }
    }

}

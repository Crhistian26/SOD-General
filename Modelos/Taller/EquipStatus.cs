using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Taller
{
    public class EquipStatus
    {
        public int IdEquipStatus { get; set; }
        public string Status { get; set; }
        public bool Enabled { get; set; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="EquipStatus"/>
        /// </summary>
        /// <param name="idEquipStatus">ID del estado del equipo.</param>
        /// <param name="status">El nombre del estado.</param>
        /// <param name="enabled">Indica si el estado esta habilitado para su uso.</param>
        public EquipStatus(int idEquipStatus, string status, bool enabled)
        {
            IdEquipStatus = idEquipStatus;
            Status = status;
            Enabled = enabled;
        }
    }

}

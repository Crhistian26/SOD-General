using System;

namespace Modelos.Taller
{
    public class OutputEquip
    {
        public int IdOutput { get; set; }
        public int EntranceId { get; set; }
        public int TecnicalVerifyId { get; set; }
        public DateTime OutputDate { get; set; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="OutputEquip"/>.
        /// </summary>
        /// <param name="idOutput">ID de la salida de equipo.</param>
        /// <param name="entranceId">ID de la entrada asociada.</param>
        /// <param name="tecnicalVerifyId">ID del técnico de verificación.</param>
        /// <param name="outputDate">Fecha de la salida.</param>
        public OutputEquip(int idOutput, int entranceId, int tecnicalVerifyId, DateTime outputDate)
        {
            IdOutput = idOutput;
            EntranceId = entranceId;
            TecnicalVerifyId = tecnicalVerifyId;
            OutputDate = outputDate;
        }
    }

}

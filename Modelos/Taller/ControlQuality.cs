namespace Modelos.Taller
{
    public class ControlQuality
    {
        public int IdControlQuality { get; set; }
        public int ControlId { get; set; }
        public int EntranceId { get; set; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="ControlQuality"/>.
        /// </summary>
        /// <param name="idControlQuality">ID de la calidad de control.</param>
        /// <param name="controlId">ID del control asociado.</param>
        /// <param name="entranceId">ID de la entrada asociada.</param>
        public ControlQuality(int idControlQuality, int controlId, int entranceId)
        {
            IdControlQuality = idControlQuality;
            ControlId = controlId;
            EntranceId = entranceId;
        }
    }

}

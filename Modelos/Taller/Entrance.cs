using System;

namespace Modelos.Taller
{
    public class Entrance
    {
        public int IdEntrance { get; set; }
        public int PetitionId { get; set; }
        public int EquipmentId { get; set; }
        public int TecnicalRepairId { get; set; }
        public int ClientId { get; set; }
        public int EquipStatusId { get; set; }
        public DateTime EntranceDate { get; set; }
        public string Serial { get; set; }
        public string Fault { get; set; }
        public int? CountPrinter { get; set; }
        public int Code { get; set; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Entrance"/>.
        /// </summary>
        /// <param name="idEntrance">ID de la entrada.</param>
        /// <param name="petitionId">ID de la petición asociada.</param>
        /// <param name="equipmentId">ID del equipo asociado.</param>
        /// <param name="tecnicalRepairId">ID del técnico de reparación asociado.</param>
        /// <param name="clientId">ID del cliente asociado.</param>
        /// <param name="equipStatusId">ID del estado del equipo asociado.</param>
        /// <param name="entranceDate">Fecha de la entrada.</param>
        /// <param name="serial">Número de serie del equipo.</param>
        /// <param name="fault">Descripción de la falla del equipo.</param>
        /// <param name="countPrinter">Cantidad de impresiones si el equipo imprime.</param>
        /// <param name="code">Código asociado.</param>
        public Entrance(int idEntrance, int petitionId, int equipmentId, int tecnicalRepairId,
                        int clientId, int equipStatusId, DateTime entranceDate, string serial,
                        string fault, int? countPrinter, int code)
        {
            IdEntrance = idEntrance;
            PetitionId = petitionId;
            EquipmentId = equipmentId;
            TecnicalRepairId = tecnicalRepairId;
            ClientId = clientId;
            EquipStatusId = equipStatusId;
            EntranceDate = entranceDate;
            Serial = serial;
            Fault = fault;
            CountPrinter = countPrinter;
            Code = code;
        }
    }

}

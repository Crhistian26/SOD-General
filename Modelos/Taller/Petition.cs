using System;

namespace Modelos.Taller
{
    public class Petition
    {
        public int IdPetition { get; set; }
        public int ClientId { get; set; }
        public DateTime Date { get; set; }
        public string Details { get; set; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Petition"/>
        /// </summary>
        /// <param name="idPetition">ID de la peticion.</param>
        /// <param name="clientId">ID del cliente.</param>
        /// <param name="date">Fecha de la peticion.</param>
        /// <param name="details">Detalles de la peticion.</param>
        public Petition(int idPetition, int clientId, DateTime date, string details)
        {
            IdPetition = idPetition;
            ClientId = clientId;
            Date = date;
            Details = details;
        }
    }

}

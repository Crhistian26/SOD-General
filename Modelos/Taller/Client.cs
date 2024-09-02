namespace Modelos.Taller
{
    public class Client
    {
        public int? IdClient { get; set; }
        public string _Identifier { get; set; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Client"/>.
        /// </summary>
        /// <param name="idClient">ID del cliente.</param>
        /// <param name="name">Nombre del cliente.</param>
        /// <param name="address">Dirección del cliente.</param>
        /// <param name="identifier">Identificador del cliente.</param>
        /// <param name="phone1">Teléfono principal del cliente.</param>
        /// <param name="phone2">Teléfono secundario del cliente.</param>
        /// <param name="contact">Contacto del cliente.</param>
        public Client(int? idClient, string identifier)
        {
            IdClient = idClient;
            _Identifier = identifier;
        }
    }

}

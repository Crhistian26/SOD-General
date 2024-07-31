using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Taller
{
    public class Client
    {
        public int? IdClient { get; set; }
        public string _NameBranch { get; set; }
        public string _Name { get; set; }
        public string _Address { get; set; }
        public string _Identifier { get; set; }
        public string Phone_1 { get; set; }
        public string Phone_2 { get; set; }
        public string _Contact { get; set; }

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
        public Client(int? idClient, string nameBranch, string name, string address, string identifier, string phone1, string phone2, string contact)
        {
            IdClient = idClient;
            _NameBranch = nameBranch;
            _Name = name;
            _Address = address;
            _Identifier = identifier;
            Phone_1 = phone1;
            Phone_2 = phone2;
            _Contact = contact;
        }
    }

}

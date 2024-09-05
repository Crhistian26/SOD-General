using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Taller
{

    public class Contact
    {
        public int IdContact { get; set; }
        public string ContactName { get; set; }
        public string identifier { get; set; }
        public string numero1 { get; set; }
        public string numero2 { get; set; }

        public Contact(string ContactName, string identifier, string numero1, string numero2)
        {
            this.ContactName = ContactName;
            this.identifier = identifier;
            this.numero1 = numero1;
            this.numero2 = numero2;
        }

        public Contact(string ContactName, string identifier, string numero1, string numero2, int IdContact)
            :this(ContactName, identifier, numero1, numero2)
        {
            this.IdContact = IdContact;

        }

    }

    
}

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
        public string numero1 { get; set; }

        public Contact(string ContactName, string numero1)
        {
            this.ContactName = ContactName;
            this.numero1 = numero1;
        }

        public Contact(string ContactName, string numero1,int IdContact)
            :this(ContactName,numero1)
        {
            this.IdContact = IdContact;

        }

    }

    
}

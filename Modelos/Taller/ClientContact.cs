using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Taller
{
    public class ClientContact
    {
        public int IdClientContact { get; set; }
        public Locations locat { get; set; }
        public Contact contc { get; set; }

        public ClientContact(int idClientContact, Locations locat, Contact contc)
        {
            this.IdClientContact = idClientContact;
            this.locat = locat;
            this.contc = contc; 
        }
        
    }
}

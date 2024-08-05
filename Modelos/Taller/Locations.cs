using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Taller
{
    public class Locations
    {
        public int? IdLocation {  get; set; }
        public int? IdClient { get; set; }
        public string _Location { get; set; }
        public string Addrees { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Contact { get; set; }


        public Locations(int IdLocation, int IdClient, string _Location, string Address, string Phone1, string Phone2, string Contact)
        {
            this.IdLocation = IdLocation;
            this.IdClient = IdClient;
            this._Location = _Location;
            this.Addrees = Address;
            this.Phone1 = Phone1;
            this.Phone2 = Phone2;
            this.Contact = Contact;
        }

    }
}

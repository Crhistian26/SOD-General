namespace Modelos.Taller
{
    public class Locations
    {
        public int? IdLocation { get; set; }
        public int? IdClient { get; set; }
        public int? IdContact { get; set; }
        public string _Location { get; set; }
        public string Addrees { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Identifier { get; set; }


        /// <summary>
        /// constructor que solo admite datos del cliente sin la identificacion
        /// </summary>
        /// <param name="IdLocation"></param>
        /// <param name="IdClient"></param>
        /// <param name="IdContact"></param>
        /// <param name="_Location"></param>
        /// <param name="Address"></param>
        /// <param name="Phone1"></param>
        /// <param name="Phone2"></param>
        public Locations(int? IdLocation, int? IdClient, int? IdContact, string _Location, string Address, string Phone1, string Phone2)
        {
            this.IdLocation = IdLocation;
            this.IdClient = IdClient;
            this.IdContact = IdContact;
            this._Location = _Location;
            this.Addrees = Address;
            this.Phone1 = Phone1;
            this.Phone2 = Phone2;
            
        }

        /// <summary>
        /// Constructor que tiene definido el idenficador y llama los otros datos del Constructor anterior
        /// </summary>
        /// <param name="IdLocation"></param>
        /// <param name="IdClient"></param>
        /// <param name="IdContact"></param>
        /// <param name="_Location"></param>
        /// <param name="Address"></param>
        /// <param name="Phone1"></param>
        /// <param name="Phone2"></param>
        /// <param name="Identfier"></param>
        public Locations(int? IdLocation, int? IdClient, int? IdContact, string _Location, string Address, string Phone1, string Phone2, string Identfier) 
            :this(IdLocation, IdClient, IdContact, _Location, Address, Phone1, Phone2)
        {
            this.Identifier = Identfier;
        }


    }
}

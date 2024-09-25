using DocumentFormat.OpenXml.Drawing.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Taller
{
    public class EntryOrderData
    {
        public Petition peticion { get; set; }

        public ClientContact clienteContacto { get; set; }


        public EntryOrderData(Petition peticion, ClientContact clienteContacto) 
        {
            this.peticion = peticion;
            this.clienteContacto = clienteContacto;

        
        }
    }
}

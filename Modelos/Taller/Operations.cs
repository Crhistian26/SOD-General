using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Taller
{
    /// <summary>
    /// modelo para almacenar los modulos, las operaciones que tendran 
    /// los modulos y los eventos relacionados a estos
    /// </summary>
    public class Operations
    {
        
        public string Modulo { get; set; }

        public string Operaciones { get; set; }

        public EventHandler Evento {  get; set; }

        public Operations(string Modulo, string Operaciones, EventHandler Evento)
        {
            this.Modulo = Modulo;
            this.Operaciones = Operaciones;
            this.Evento = Evento;   
        }
    }


    
}

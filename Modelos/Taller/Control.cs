using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Taller
{
    public class Control
    {
        public int IdControl { get; set; }
        public string Name { get; set; }
        public bool Enabled { get; set; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Control"/>.
        /// </summary>
        /// <param name="idControl">ID del control.</param>
        /// <param name="name">Nombre del control.</param>
        /// <param name="enabled">Indica si el control está habilitado.</param>
        public Control(int idControl, string name, bool enabled)
        {
            IdControl = idControl;
            Name = name;
            Enabled = enabled;
        }
    }

}

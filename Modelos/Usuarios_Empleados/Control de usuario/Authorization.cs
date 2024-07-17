using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Usuarios_Empleados
{
    public class Authorization
    {
        public int IdAuthorization { get; set; }
        public string _Authorization { get; set; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Authorization"/>.
        /// </summary>
        /// <param name="idAuthorization">ID de la autorización.</param>
        /// <param name="authorization">Nombre de la autorización.</param>
        public Authorization(int idAuthorization, string authorization)
        {
            IdAuthorization = idAuthorization;
            _Authorization = authorization;
        }
    }

}

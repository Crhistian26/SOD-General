using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Usuarios_Empleados
{
    public class MAuthorization
    {
        public int IdAuthorization { get; set; }
        public string _Authorization { get; set; }

        public string _AuthotizationType { get; set; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Authorization"/>.
        /// </summary>
        /// <param name="idAuthorization">ID de la autorización.</param>
        /// <param name="authorization">Nombre de la autorización.</param>
        /// <param name="authorizationtype">El tipo de autorizacion si pertenece a algun departamento o si es adicional.</param>
        public MAuthorization(int idAuthorization, string authorization, string authorizationtype)
        {
            IdAuthorization = idAuthorization;
            _Authorization = authorization;
            _AuthotizationType = authorizationtype;
        }
    }

}

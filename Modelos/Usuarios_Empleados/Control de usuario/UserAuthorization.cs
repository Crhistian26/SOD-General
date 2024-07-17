using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Usuarios_Empleados.Control_de_usuario
{
    public class UserAuthorization
    {
        public int IdEmpleaAuto { get; set; }
        public int UserId { get; set; }
        public int AuthorizationId { get; set; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="UserAuthorization"/>.
        /// </summary>
        /// <param name="idEmpleaAuto">ID de la autorización del usuario.</param>
        /// <param name="userId">ID del usuario.</param>
        /// <param name="authorizationId">ID de la autorización.</param>
        public UserAuthorization(int idEmpleaAuto, int userId, int authorizationId)
        {
            IdEmpleaAuto = idEmpleaAuto;
            UserId = userId;
            AuthorizationId = authorizationId;
        }
    }

}

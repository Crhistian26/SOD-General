using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Usuarios_Empleados
{
    public class DepartAuthorization
    {
        public int IdDepartAutho { get; set; }
        public int DepartmentId { get; set; }
        public int AuthorizationId { get; set; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="DepartAuthorization"/>.
        /// </summary>
        /// <param name="idDepartAutho">ID de la autorización del departamento.</param>
        /// <param name="departmentId">ID del departamento.</param>
        /// <param name="authorizationId">ID de la autorización.</param>
        public DepartAuthorization(int idDepartAutho, int departmentId, int authorizationId)
        {
            IdDepartAutho = idDepartAutho;
            DepartmentId = departmentId;
            AuthorizationId = authorizationId;
        }
    }

}

namespace Modelos.Usuarios_Empleados.Control_de_usuario
{
    public class User
    {
        public int IdUser { get; set; }
        public int EmployeeId { get; set; }
        public string _User { get; set; }
        public string _Password { get; set; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="User"/>.
        /// </summary>
        /// <param name="idUser">ID del usuario.</param>
        /// <param name="employeeId">ID del empleado.</param>
        /// <param name="user">Nombre de usuario.</param>
        /// <param name="password">Contraseña del usuario.</param>
        public User(int idUser, int employeeId, string user, string password)
        {
            IdUser = idUser;
            EmployeeId = employeeId;
            _User = user;
            _Password = password;
        }
    }
}

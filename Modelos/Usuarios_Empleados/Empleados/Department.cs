namespace Modelos.Usuarios_Empleados
{
    public class Department
    {
        public int IdDepartment { get; set; }
        public string _Department { get; set; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Department"/>.
        /// </summary>
        /// <param name="idDepartment">ID del departamento.</param>
        /// <param name="department">Nombre del departamento.</param>
        public Department(int idDepartment, string department)
        {
            IdDepartment = idDepartment;
            _Department = department;
        }
    }
}

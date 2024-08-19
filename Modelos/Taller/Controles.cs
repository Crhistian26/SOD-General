
namespace Modelos.Taller
{
    public class Controles
    {
        public int idControl { get; set; }
        public string Name { get; set; }
        public bool Enabled { get; set; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Control"/>.
        /// </summary>
        /// <param name="idControl">ID del control.</param>
        /// <param name="name">Nombre del control.</param>
        /// <param name="enabled">Indica si el control está habilitado.</param>
        public Controles(int IdControl, string _name, bool _enabled)
        {
            idControl = IdControl;
            Name = _name;
            Enabled = _enabled;
        }
    }
}

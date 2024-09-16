namespace Modelos.Taller
{
    public class Brand
    {
        public int? IdBrand { get; set; }
        public string _Brand { get; set; }
        public bool _Enabled { get; set; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Brand"/>.
        /// </summary>
        /// <param name="idBrand">ID de la marca.</param>
        /// <param name="brand">Nombre de la marca.</param>
        /// <param name="enabled">Estado de habilitación de la marca.</param>
        public Brand(int? idBrand, string brand, bool enabled)
        {
            IdBrand = idBrand;
            _Brand = brand;
            _Enabled = enabled;
        }
    }
}

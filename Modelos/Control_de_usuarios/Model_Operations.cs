namespace Modelos.Control_de_usuarios
{
    public class Model_Operations
    {
        public int Id_Operation { get; set; }
        public string _Module { get; set; }
        public string _Operation { get; set; }

        public Model_Operations(string module, string operation)
        {
            this._Module = module;
            this._Operation = operation;
        }

        public Model_Operations(int id, string module, string operation)
            :this (module,operation)
        {
            this.Id_Operation = id;
        }
    }
}

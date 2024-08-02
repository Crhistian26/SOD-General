using SOD_General.Vistas.Recursos_Humanos.Motivos;

namespace SOD_General.Controladores
{
    internal class Motivos_Controller
    {

        
        public void AbrirEditar(int? y)
        {
            if (y is null)
            {
                AgregarEditar_Motivos hola = new AgregarEditar_Motivos();
                hola.Show();
            }
            else
            {
                AgregarEditar_Motivos hola = new AgregarEditar_Motivos(y);
                hola.Show();
            }
        }
    }
}

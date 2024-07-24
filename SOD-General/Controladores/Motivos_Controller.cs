using SOD_General.Vistas.Recursos_Humanos.Motivos;
using SOD_General.Vistas.Recursos_Humanos.Registros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOD_General.Controladores
{
    internal class Motivos_Controller
    {
        
        public Motivos_Controller()
        {
            
        }
        public void AbrirEditar(int? y)
        {
            if(y is null)
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

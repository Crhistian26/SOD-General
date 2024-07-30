using SOD_General.Vistas.Recursos_Humanos.Empleados;
using SOD_General.Vistas.Recursos_Humanos.Motivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOD_General.Controladores
{
    internal class Empleados_Controller
    {
        public void AbrirEditar()
        {
            AgregarEditar_Empleados hola = new AgregarEditar_Empleados();
            hola.Show();
        }
        public void AbrirEditar(int y)
        {
                AgregarEditar_Empleados hola = new AgregarEditar_Empleados(y);
                hola.Show();
        }
        public void AbrirEditar(string y)
        {
                AgregarEditar_Empleados hola = new AgregarEditar_Empleados(y);
                hola.Show();
        }

       
        
    }
}

using SOD_General.Vistas.Recursos_Humanos.Registros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOD_General.Controladores
{
    internal class Registros_Controller
    {
        public void AgregarPermiso()
        {
            Agregar_Permiso vista = new Agregar_Permiso();
            vista.Show();
        }

        public void AgregarAsistencia()
        {
            Agregar_Asistencias vista = new Agregar_Asistencias();
            vista.Show();
        }

    }
}

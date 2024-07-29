using Modelos.Taller;
using SOD_General.Taller.Registro_peticiones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SOD_General.Controladores
{
    public class FormsController
    {
        List<Operations> OperacionesEvento = new List<Operations>();
        Operations ConjuntoOperaciones;
        public void AddCotizacion()
        {
            AgregarCotizaciones addCot = new AgregarCotizaciones();
            addCot.Show();
        }

        public void AddEntradas()
        {
            AgregarPeticiones addPet = new AgregarPeticiones();
            addPet.Show();
        }

        
    }
}

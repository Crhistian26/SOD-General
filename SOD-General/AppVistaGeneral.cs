using Modelos.Usuarios_Empleados;
using SOD_General.Vistas_Taller.Taller_Recepcion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOD_General
{
    public partial class AppVistaGeneral : Form
    {

        //La lista de autorizaciones.
        List<MAuthorization> authorizations = new List<MAuthorization>();

        //El constructor que captura la lista y la llena.
        public AppVistaGeneral(List<MAuthorization> authorizations)
        {
            InitializeComponent();
            this.authorizations = authorizations;
        }

        //La aplicacion cargando.
        private void AppVistaGeneral_Load(object sender, EventArgs e)
        {
            
        }

        public event EventHandler ReajustarSize;

    }
}

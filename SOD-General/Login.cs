using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOD_General
{
    public class Permisos
    {
        public string Authorization { get; set; }
        public string AuthorizationType { get; set; }
    }
    public partial class Login : Form
    {
        VistaPrincipal principal { get; set; }
        List<Permisos> Permisos = new List<Permisos>();

        public Login(VistaPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void botones_Nuevos1_Click(object sender, EventArgs e)
        {
            principal.AbrirVistaGeneral(new AppVistaGeneral());
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zkemkeeper;

namespace SOD_General.Vistas.Recursos_Humanos.Registros
{
    public partial class Ponchador : Form
    {
        public Ponchador()
        {
            InitializeComponent();
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            CZKEM zkt = new CZKEM();

            string ip = "192.168.17.201";
            int puerto = 4370;

            if (zkt.Connect_Net(ip, puerto))
            {
                MessageBox.Show("Conexion con el ponchador funcionando correctamente");
            }
            else
            {
                MessageBox.Show("Se ha perdido la conexion con el ponchador");
            }
        }
    }
}

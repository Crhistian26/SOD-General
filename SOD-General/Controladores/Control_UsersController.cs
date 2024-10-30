using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOD_General.Controladores
{
    internal class Control_UsersController
    {
        static private General_Controller _general = new General_Controller();

        static private SqlConnection conex = _general.GetConnection();

        
    }
}

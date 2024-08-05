using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Control_de_usuarios
{
    public class Model_User
    {
        public int Id_User { get; set; }
        public int Employye_Id { get; set; }
        public Model_Role _Role { get; set; }
        public string User_Name { get; set; }
        public string _Password { get; set; }

        public Model_User(int id_User, int employye_Id, Model_Role role, string user_Name, string password)
        {
            this.Id_User = id_User;
            this.Employye_Id = employye_Id;
            this._Role = role;
            this.User_Name = user_Name;
            this._Password = password;
        }
    }
}

using System.Linq;

namespace Modelos.Control_de_usuarios
{
    public class Model_User
    {
        public int Id_User { get; set; }
        public int Employye_Id { get; set; }
        public Model_Role _Role { get; set; }
        public string Name { get; set; }    
        public string User_Name { get; set; }
        public string _Password { get; set; }
        public bool _State { get; set; }

        public Model_User() { }

        public Model_User(int id_User, string Name_employee, string user_Name, Model_Role role)
        {
            this.Id_User = id_User;
            this.Name = Name_employee;
            this._Role = role;
            this.User_Name = user_Name;
        }

        public Model_User(int id_User, int employye_Id, Model_Role role, string name, string user_Name, string password, bool state) 
        {
            this.Id_User = id_User;
            this.Employye_Id = employye_Id;
            this._Role = role;
            this.User_Name = user_Name;
            this.Name = name;
            _Password = password;
            _State = state;
        }

        public Model_User(int id_User, int employye_Id, Model_Role role, string user_Name, string password)
        {
            this.Id_User = id_User;
            this.Employye_Id = employye_Id;
            this._Role = role;
            this.User_Name = user_Name;
            this._Password = password;
        }

        public Model_User(int id_User, int employye_Id, Model_Role role, string user_Name, string password, bool state) 
            : this(id_User, employye_Id, role, user_Name, password)
        {
            _State = state;
        }

        public bool Confirm_Operation(string Operation_name)
        {
            var hola = this._Role._Operations.Where(a => a._Operation == Operation_name).Select(a => a).FirstOrDefault();

            if (hola != null)
            {
                return true;
            }
            return false;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.BL.Model;

namespace Shop.BL.Controller
{
    public class UserController: BaseController
    {
        public List<Model.User> Users;
        public Model.User CurrentUser;
        private int ind = -1;
        public bool NewUser { get => ind == -1; }

        public UserController(string name)
        {
            Users=Load();
            ind = Users.FindIndex(u => u.Name == name);
           
        }

        public void AddNewUser(string name,string passwordNew, string passwordReplay)
        {
            CurrentUser = new User.Buyer(name, passwordNew, passwordReplay);
            Users.Add(CurrentUser);
            Save(Users);
            ind = Users.Count - 1;
        }
        public void SelectUser(string password)
        {
            CurrentUser = Users[ind].GetUser(password);
        }

    
    }
}

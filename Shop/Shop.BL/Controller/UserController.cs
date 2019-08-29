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
        private const string USERS_PACH_NAME = "Users.dat";
        private List<Model.User> Users;
        public Model.User CurrentUser;
        
        public bool NewUser=false;

        public UserController(string name)
        {
            Users=Load<List<Model.User>>(USERS_PACH_NAME) ?? new List<Model.User>();
            CheckAdmin();
            NewUser = (Users.FindIndex(u => u.Name == name)==-1);
           
        }
        private void CheckAdmin()
        {
            if (Users.Find(u => u is User.Admin) == null)
            {
                Users.Add(new User.Admin("Admin", "admin", "admin"));
                Save(Users, USERS_PACH_NAME);
            }
        }
        public void AddNewUser(string name,string passwordNew, string passwordReplay)
        {
            CurrentUser = new User.Buyer(name, passwordNew, passwordReplay);
            if (CurrentUser==null)
            {
                return;
            }
            Users.Add(CurrentUser);
            Save(Users, USERS_PACH_NAME);
            NewUser = false;
            SelectUser(name, passwordNew);
        }
        public void SelectUser(string name, string password)
        {
            CurrentUser = Users.Find(u=>u.Name==name).GetUser(password);
        }

    
    }
}

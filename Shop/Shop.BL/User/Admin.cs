using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.BL.User
{
    public class Admin : Model.User
    {
        private int AccessRights { get; set; } = 0;
        public Admin(
            string name,
            string passwordNew,
            string passwordReplay,
            string adress,
            int balance,
            int spent) : base(name, passwordNew, passwordReplay)
        {
        }
    }
}

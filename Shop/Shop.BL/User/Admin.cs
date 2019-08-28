using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.BL.User
{
    [Serializable]
    public class Admin : Model.User
    {
        private int AccessRights { get; set; } = 0;
        public Admin(
            string name,
            string passwordNew,
            string passwordReplay) : base(name, passwordNew, passwordReplay)
        {
        }
    }
}

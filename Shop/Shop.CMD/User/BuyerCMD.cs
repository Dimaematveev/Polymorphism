using Shop.BL.User;
using Shop.CMD.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.CMD.User
{
    class BuyerCMD : Buyer,IToConsole
    {
        public BuyerCMD(string name) : base(name)
        {
        }

        public BuyerCMD(string name,
                        string passwordNew,
                        string passwordReplay) : base(name, passwordNew, passwordReplay)
        {
        }

        public BuyerCMD(string name,
                        string passwordNew,
                        string passwordReplay,
                        string adress,
                        int balance,
                        int spent) : base(name, passwordNew, passwordReplay, adress, balance, spent)
        {
        }

        public void ToConsole()
        {
            Console.WriteLine($"Здравствуйте {Name} ваш баланс {Balance}");
        }
    }
}

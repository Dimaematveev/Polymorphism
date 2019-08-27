using Shop.BL.Model;
using Shop.CMD.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.CMD.Model
{
    public class ProductCMD : Product,IToConsole
    {
        public ProductCMD()
        {
        }

        public void ToConsole()
        {
            Console.WriteLine(this.Name);
        }
    }
}

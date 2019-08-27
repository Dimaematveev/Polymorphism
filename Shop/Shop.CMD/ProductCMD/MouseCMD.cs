using Shop.BL.Product;
using Shop.CMD.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.CMD.ProductCMD
{
    public class MouseCMD : Mouse,IToConsole
    {
        public MouseCMD(string name,
                        int price,
                        string manufacturer) : base(name, price, manufacturer)
        {
        }
        public void ToConsole()
        {
            Console.WriteLine("Мышь:");
            Console.WriteLine("  Название: " + Name);
            Console.WriteLine("  Цена: " + Price);
            Console.WriteLine("  Производитель: " + Manufacturer);
        }
    }
}

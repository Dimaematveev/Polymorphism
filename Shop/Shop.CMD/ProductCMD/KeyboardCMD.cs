using Shop.BL.Product;
using Shop.CMD.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.CMD.ProductCMD
{
    public class KeyboardCMD : Keyboard, IToConsole
    {
        public KeyboardCMD(string name,
                           int price,
                           string manufacturer,
                           int numberOfKeys) : base(name, price, manufacturer, numberOfKeys)
        {
        }

        public void ToConsole()
        {
            Console.WriteLine("Клавиатура:");
            Console.WriteLine("  Название: " + Name);
            Console.WriteLine("  Цена: " + Price);
            Console.WriteLine("  Производитель: " + Manufacturer);
            Console.WriteLine("  Количество клавиш: " + NumberOfKeys);
        }
    }
}

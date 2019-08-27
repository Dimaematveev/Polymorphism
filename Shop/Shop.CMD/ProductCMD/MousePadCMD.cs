using Shop.BL.Product;
using Shop.CMD.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.CMD.ProductCMD
{
    public class MousePadCMD : MousePad,IToConsole
    {
        public MousePadCMD(string name,
                           int price,
                           string manufacturer,
                           string composition) : base(name, price, manufacturer, composition)
        {
        }
        public void ToConsole()
        {
            Console.WriteLine("Коврик для мыши:");
            Console.WriteLine("  Название: " + Name);
            Console.WriteLine("  Цена: " + Price);
            Console.WriteLine("  Производитель: " + Manufacturer);
            Console.WriteLine("  Состав: " + Composition);
        }
    }
}

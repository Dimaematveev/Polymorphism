using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.BL.Product
{
    /// <summary>
    /// Мышь.
    /// </summary>
    public class Mouse: Model.Product
    {
        public Mouse(string name, int price, string manufacturer)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
        }
    }
}

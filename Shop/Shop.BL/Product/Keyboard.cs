using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.BL.Product
{
    /// <summary>
    /// Клавиатура.
    /// </summary>
    [Serializable]
    public class Keyboard: Model.Product
    {
        /// <summary>
        /// Количество клавиш.
        /// </summary>
        public int NumberOfKeys { get; set; }
        public Keyboard(string name, int price, string manufacturer, int numberOfKeys)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
            NumberOfKeys = numberOfKeys;
        }
    }
}

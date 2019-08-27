﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.BL.Product
{
    /// <summary>
    /// Коврик для мыши.
    /// </summary>
    public class MousePad: Model.Product
    {
        /// <summary>
        /// Из чего коврик.
        /// </summary>
        public string Composition { get; set; }
        public MousePad(string name, int price, string manufacturer, string composition)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
            Composition = composition;
        }
    }
}

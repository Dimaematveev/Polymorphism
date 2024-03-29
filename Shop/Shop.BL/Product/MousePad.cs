﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.BL.Model;

namespace Shop.BL.Product
{
    /// <summary>
    /// Коврик для мыши.
    /// </summary>
    [Serializable]
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
        internal override double GetDiscountPrice(User.Buyer buyer)
        {
            return Price/5;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.BL.User;

namespace Shop.BL.Model
{
    /// <summary>
    /// Продукт.
    /// </summary>
    public abstract class Product
    {
        /// <summary>
        /// Цена.
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Название.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Марка(Модель).
        /// </summary>
        public string Manufacturer { get; set; }

        /// <summary>
        /// Виртуальный метод цены товара.
        /// </summary>
        /// <param name="user">Пользователь покупающий товар.</param>
        /// <returns>Цена товара.</returns>
       internal virtual double GetDiscountPrice(Buyer buyer)
        {
            if (buyer.Spent < 300)
            {
                return Price;
            }

            if (buyer.Spent < 1000)
            {
                return Price * 0.9;
            }

            return Price * 0.8;
        }
    }
}

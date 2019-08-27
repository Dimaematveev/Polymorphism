using Shop.BL.Model;
using System;

namespace Shop.Bl.Model
{
    /// <summary>
    /// Объединяет покупателя и товар.
    /// </summary>
    public class Informer
    {
        /// <summary>
        /// Покупка.
        /// </summary>
        /// <param name="user">Покупатель.</param>
        /// <param name="product">Товар.</param>
        public void Buy(User user, Product product)
        {
            double price = product.GetDiscountPrice(user);
            user.ReduceBalance(price);
            if (price< product.Price)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"{user.Name} купил {product.Name} со скидкой (");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{ product.Price}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($")");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{ price}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($". Заказ отправлен на склад");
            }
            else
            {
                Console.WriteLine($"{user.Name} купил {product.Name} за {price}. Заказ отправлен на склад");
            }
            
        }
    }
}

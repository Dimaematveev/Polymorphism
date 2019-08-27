using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Bl.Model;
using Shop.BL.Model;
using Shop.BL.Product;
using Shop.CMD.Interfaces;
using Shop.CMD.Model;
using Shop.CMD.ProductCMD;

namespace Shop.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User(
                "Artem",
                "Улица Пушкина, дом Колотушкина",
                100000,
                550
                );


            Keyboard keyBor = new KeyboardCMD(
                "Ультра Клавиатура!",
                400,
                "Log",
                25
                );

            Mouse mouseGeat = new MouseCMD(
                "Мышь крутая",
                500,
                "Log"
                );

            MousePad gamePad = new MousePadCMD(
                "Супер коврик",
                700,
                "Game",
                "700 pdi"
                );
           

            Product[] products = new Product[] {
                keyBor,
                mouseGeat,
                gamePad,
            };
            Informer informer = new Informer();

            while (true)
            {
                Console.WriteLine("Список товаров:");
                foreach (var product in products)
                {
                    ((IToConsole)product).ToConsole();
                    Console.WriteLine(new String('-', 25));
                }
                Console.WriteLine();
                Console.WriteLine($"Здравствуйте {user.Name} ваш баланс {user.Balance}");

                for (int i = 0; i < products.Length; i++)
                {
                    Console.WriteLine($"Товар {i} {products[i].Name} по цене {products[i].Price}");
                }
                Console.WriteLine("Выберете номер товара и нажмите Enter:");

                string str = Console.ReadLine();
                int productNumber = Convert.ToInt32(str);
                Console.Clear();
                if (productNumber >= 0 && productNumber < products.Length)
                {

                    if (products[productNumber].Price < user.Balance)
                    {
                        
                        informer.Buy(user, products[productNumber]);
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("У вас недостаточно средств");
                    }

                }
                else
                {
                    Console.WriteLine("Таких товаров нет");
                }
            }
        }
    }
}

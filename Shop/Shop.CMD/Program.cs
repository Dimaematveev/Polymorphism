using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Bl.Model;
using Shop.BL.Model;
using Shop.BL.Product;

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

            Console.WriteLine("Список товаров:");


            Keyboard keyBor = new Keyboard(
                "Ультра Клавиатура!",
                400,
                "Log",
                25
                );

            Console.WriteLine("Клавиатура:");
            Console.WriteLine("Название: " + keyBor.Name);
            Console.WriteLine("Цена: " + keyBor.Price);
            Console.WriteLine("Производитель: " + keyBor.Manufacturer);
            Console.WriteLine("Размер: " + keyBor.NumberOfKeys);
            Console.WriteLine(new String('-', 25));

            Mouse mouseGeat = new Mouse(
                "Мышь крутая",
                500,
                "Log"
                );

            Console.WriteLine("Мышь:");
            Console.WriteLine("Название: " + mouseGeat.Name);
            Console.WriteLine("Цена: " + mouseGeat.Price);
            Console.WriteLine("Производитель: " + mouseGeat.Manufacturer);
            Console.WriteLine(new String('-', 25));

            MousePad gamePad = new MousePad(
                "Супер коврик",
                700,
                "Game",
                "700 pdi"
                );

            Console.WriteLine("Коврик для мыши:");
            Console.WriteLine("Название: " + gamePad.Name);
            Console.WriteLine("Цена: " + gamePad.Price);
            Console.WriteLine("Производитель: " + gamePad.Manufacturer);
            Console.WriteLine("Состав: " + gamePad.Composition);
            Console.WriteLine(new String('-', 25));


            Product[] products = new Product[] {
                keyBor,
                mouseGeat,
                gamePad,
            };
            Console.WriteLine(new String('-', 25));
            foreach (var item in products)
            {
                Console.WriteLine($"nameof({nameof(item)})");
                Console.WriteLine($"GetType({item.GetType()})");
            }
            Console.WriteLine(new String('-', 25));
            Informer informer = new Informer();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine($"Здравствуйте {user.Name} ваш баланс {user.Balance}");

                for (int i = 0; i < products.Length; i++)
                {
                    Console.WriteLine($"Товар {i} {products[i].Name} по цене {products[i].Price}");
                }
                Console.WriteLine("Выберете номер товара и нажмите Enter:");

                string str = Console.ReadLine();
                int productNumber = Convert.ToInt32(str);

                if (productNumber >= 0 && productNumber < products.Length)
                {

                    if (products[productNumber].Price < user.Balance)
                    {
                        informer.Buy(user, products[productNumber]);
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

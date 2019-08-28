using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Bl.Model;
using Shop.BL.Controller;
using Shop.BL.Model;
using Shop.BL.Product;
using Shop.BL.User;
using Shop.CMD.Interfaces;
using Shop.CMD.Model;
using Shop.CMD.ProductCMD;

namespace Shop.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Buyer buyer = new Buyer("Artem","123456","123456","Улица Пушкина, дом Колотушкина",100000,550);
           
            Console.WriteLine("Введите имя пользователя:");
            string nameUser = Console.ReadLine();
            UserController userController = new UserController(nameUser);

            if (userController.NewUser)
            {
                Console.WriteLine("Новый пользователь!");
                Console.WriteLine("Введите пароль пользователя");
                string passNew = Console.ReadLine();
                Console.WriteLine("Повторите пароль пользователя");
                string passRet = Console.ReadLine();
                userController.AddNewUser(nameUser,passNew, passRet);
                userController.SelectUser(passNew);
            }
            else
            {
                Console.WriteLine("Введите пароль пользователя");
                string pass = Console.ReadLine();
                userController.SelectUser(pass);
            }

            Product keyBor = new KeyboardCMD("Ультра Клавиатура!", 400,"Log",25 );

            Product mouseGeat = new MouseCMD(  "Мышь крутая",  500, "Log"  );

            Product gamePad = new MousePadCMD(   "Супер коврик",  700,  "Game",  "700 pdi"  );
           

            Product[] products = new Product[] {
                keyBor,
                mouseGeat,
                gamePad,
            };
            Product product1 = new Model.ProductCMD();
            product1 = keyBor;
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
                Console.WriteLine($"Здравствуйте {buyer.Name} ваш баланс {buyer.Balance}");

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

                    if (products[productNumber].Price < buyer.Balance)
                    {
                        
                        informer.Buy(buyer, products[productNumber]);
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

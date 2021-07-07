﻿using System;
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
using Shop.CMD.User;

namespace Shop.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            //Buyer buyer = new Buyer("Artem","123456","123456","Улица Пушкина, дом Колотушкина",100000,550);
            UserController userController;
            do
            {
                Console.WriteLine("Введите имя пользователя:");
                string nameUser = Console.ReadLine();
                string pass = null;
                userController = new UserController(nameUser);

                if (userController.NewUser)
                {
                    do
                    {
                        Console.WriteLine("Новый пользователь!");
                        Console.WriteLine("Введите пароль пользователя");
                        string passNew = Console.ReadLine();
                        Console.WriteLine("Повторите пароль пользователя");
                        string passRet = Console.ReadLine();
                        if (passNew!= passRet)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Неправильный повторили пароль!");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            userController.AddNewUser(nameUser, passNew, passRet);
                            pass = passNew;
                            break;
                        }
                        
                    } while (true);
                   
                }
                
                if (pass==null)
                {
                    Console.WriteLine("Введите пароль пользователя");
                    pass = Console.ReadLine();
                }
                userController.SelectUser(nameUser, pass);
               
                if (userController.CurrentUser == null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неправильный пароль!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Доступ разрешен!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            } while (userController.CurrentUser == null);


            ProductController productController = new ProductController();
            if (userController.CurrentUser is Buyer buyer)
            {
                Informer informer = new Informer();

                while (true)
                {
                    Console.WriteLine("Список товаров:");
                    foreach (var product in productController.Products)
                    {
                        ((IToConsole)product).ToConsole();
                        Console.WriteLine(new String('-', 25));
                    }
                    Console.WriteLine();


                   
                    Console.WriteLine($"Здравствуйте {buyer.Name} ваш баланс {buyer.Balance}");

                    int i = 0;
                    foreach (var product in productController.Products)
                    {
                        Console.WriteLine($"Товар {i++} {product.Name} по цене {product.Price}");
                    }
                    Console.WriteLine("Выберете номер товара и нажмите Enter:");

                    string str = Console.ReadLine();
                    int productNumber = Convert.ToInt32(str);
                    Console.Clear();
                    if (productNumber >= 0 && productNumber < productController.Products.Count)
                    {

                        if (productController.Products[productNumber].Price < buyer.Balance)
                        {

                            informer.Buy(buyer, productController.Products[productNumber]);
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

            if (userController.CurrentUser is Admin admin)
            {

            }
        }
    }
}

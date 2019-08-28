using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.BL.Model
{
    /// <summary>
    /// Пользователь
    /// </summary>
    public class User
    {
        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// Пароль
        /// </summary>
        private string Password {  get;  set; }
        /// <summary>
        /// Адрес.
        /// </summary>
        public string Adress { get; private set; }
        /// <summary>
        /// Сколько денег на счету.
        /// </summary>
        public double Balance { get; private set; }
        /// <summary>
        /// Сколько всего потратил.
        /// </summary>
        public double Spent { get; private set; }

        public User(string name, string passwordNew, string passwordReplay, string adress, int balance, int spent)
        {
            Name = name;
            ChangePassword(null, passwordNew, passwordReplay);
            Adress = adress;
            Balance = balance;
            Spent = spent;
        }

        /// <summary>
        /// Покупка на сумму.
        /// </summary>
        /// <param name="price">Сумма.</param>
        public void ReduceBalance(double price)
        {
            Balance -= price;
            Spent += price;
        }

        public void ChangePassword(string passwordOdl, string passwordNew, string passwordReplay)
        {
            if (Password == passwordOdl)
            {
                if (passwordNew == passwordReplay) 
                {
                    Password = passwordNew;
                    return;
                }
                else
                {
                    throw new ArgumentException("Неверно повторили пароль!!!");
                }
            }
            else
            {
                throw new ArgumentException("Старый пароль введен неверно!!!");
            }
        }
    }
}

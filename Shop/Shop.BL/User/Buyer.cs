using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.BL.User
{
    public class Buyer : Model.User
    {
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
        public Buyer(
            string name,
            string passwordNew,
            string passwordReplay,
            string adress,
            int balance,
            int spent) : base(name, passwordNew, passwordReplay)
        {
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

    }
}

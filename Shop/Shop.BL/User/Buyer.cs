using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.BL.User
{
    [Serializable]
    public class Buyer : Model.User
    {
        /// <summary>
        /// Адрес.
        /// </summary>
        public string Adress { get; private set; }
        /// <summary>
        /// Сколько денег на счету.
        /// </summary>
        public double Balance { get; private set; } = 0;
        /// <summary>
        /// Сколько всего потратил.
        /// </summary>
        public double Spent { get; private set; } = 0;
        public Buyer(string name) : base(name){ }
        public Buyer(
            string name,
            string passwordNew,
            string passwordReplay) : base(name, passwordNew, passwordReplay) { }
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

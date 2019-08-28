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
    public abstract class User
    {
        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// Пароль
        /// </summary>
        private string Password {  get;  set; }
       

        public User(
            string name,
            string passwordNew,
            string passwordReplay)
        {
            Name = name;
            ChangePassword(null, passwordNew, passwordReplay);
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

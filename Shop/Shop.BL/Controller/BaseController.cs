using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Shop.BL.Controller
{
    public abstract class BaseController
    {
        public List<Model.User> Load()
        {
            // создаем объект BinaryFormatter
            BinaryFormatter formatter = new BinaryFormatter();
            var varible = new List<Model.User>();
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("Users.dat", FileMode.OpenOrCreate))
            {
                varible=(List<Model.User>)formatter.Deserialize(fs);
            }
            return varible;
            
        }
        public void Load(List<Model.Product> varible) 
        {
            varible = default(List<Model.Product>);

        }
        public void Save(List<Model.User> Users)
        {
            // создаем объект BinaryFormatter
            BinaryFormatter formatter = new BinaryFormatter();
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("Users.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, Users);
            }

        }
    }
}

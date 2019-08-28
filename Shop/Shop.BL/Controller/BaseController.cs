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
        public T Load<T>(string pathFile)
        {
            // создаем объект BinaryFormatter
            BinaryFormatter formatter = new BinaryFormatter();
            T varible;
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream(pathFile, FileMode.OpenOrCreate))
            {
                varible=(T)formatter.Deserialize(fs);
            }
            return varible;
            
        }
        public void Save<T>(T Users, string pathFile)
        {
            // создаем объект BinaryFormatter
            BinaryFormatter formatter = new BinaryFormatter();
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream(pathFile, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, Users);
            }

        }
    }
}

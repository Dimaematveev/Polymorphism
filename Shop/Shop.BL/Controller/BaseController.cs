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
            var formatter = new BinaryFormatter();
            using (var fs = new FileStream(pathFile, FileMode.OpenOrCreate))
            {

                if (fs.Length > 0 && formatter.Deserialize(fs) is T varible)
                {
                    return varible;
                }
                else
                {
                    return default(T);
                }

            }

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

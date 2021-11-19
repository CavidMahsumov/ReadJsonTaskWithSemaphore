using Newtonsoft.Json;
using ReadJsonTaskWithSemaphore.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadJsonTaskWithSemaphore.Json
{
    public class JsonHelper
    {
        public const string filename  = "1.json";
        public static void JSONSerialization(DataBase dataBase)
        {
            var serializer = new JsonSerializer();
            using (StreamWriter streamWriter = new StreamWriter(filename))
            {
                using (JsonTextWriter jsonTextWriter = new JsonTextWriter(streamWriter))
                {
                    jsonTextWriter.Formatting = Formatting.Indented;
                    serializer.Serialize(jsonTextWriter, dataBase);
                }
            }
        }
        public static void JSONDeSerialization(ref DataBase dataBase)
        {
            var serializer = new JsonSerializer();

            using (StreamReader streamReader = new StreamReader(filename))
            {
                using (JsonTextReader jsonTextReader = new JsonTextReader(streamReader))
                {
                    dataBase=serializer.Deserialize<DataBase>(jsonTextReader);
                }
            }
        }
    }
}

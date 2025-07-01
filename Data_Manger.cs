using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using static A8__Registration_UI.Utilities;

namespace A8__Registration_UI
{
    public class Data_Manger
    {
        private const string DataFilePath = @"..\..\..\data.xml";

        public static List<Entity> Entities = new List<Entity>();

        public static List<string> Users = new List<string>();

        public static void SaveData()
        {
            var data = new UMSData
            {
                entities = Entities
            };

            var serializer = new XmlSerializer(typeof(UMSData));
            using (var writer = new StreamWriter(DataFilePath))
            {
                serializer.Serialize(writer, data);
            }
        }

        public static void LoadData()
        {
            var serializer = new XmlSerializer(typeof(UMSData));
            using (var reader = new StreamReader(DataFilePath))
            {
                var data = (UMSData)serializer.Deserialize(reader);
                Entities = data.entities;
            }
            
            foreach (Entity user in Entities)
            {
                Users.Add(user.UserName);
            }
        }
    }

    [Serializable]
    public class UMSData
    {
        public List<Entity> entities = new List<Entity>();
    }
}

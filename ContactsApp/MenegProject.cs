using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace ContactsApp
{
    /// <summary>
    /// Класс, который содержит методы для сохранения/загрузки информации
    /// </summary>
    public class MenegProject
    {
      /// <summary>
      /// Метод для сохранения информации по контактам
      /// </summary>
      /// <param name="contacts"> та информация которую надо сохранить</param>
        public static void SaveToFile(Project contacts, string filename)//Project contactsApp
        {
            
            JsonSerializer serializer = new JsonSerializer();

            using (StreamWriter sw = new StreamWriter(filename))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                //Вызываем сериализацию и передаем объект, который хотим сериализовать
                serializer.Serialize(writer, contacts);
            }
        }
        /// <summary>
        /// Метод для загрузки информации по контактам
        /// </summary>
        public static Project Load(string filename)
        {
            Project contacts = new Project();
            JsonSerializer serializer = new JsonSerializer();

            using (StreamReader sr = new StreamReader(filename))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                contacts = (Project)serializer.Deserialize<Project>(reader);
            }

            return contacts;
        }
    }
}

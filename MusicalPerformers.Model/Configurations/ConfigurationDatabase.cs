using MusicalPerformers.Model.Exceptions;
using MusicalPerformers.Model.Serialization;
using System;
using System.IO;

namespace MusicalPerformers.Model.Configurations
{
    /// <summary>
    /// 
    /// </summary>
    public class ConfigurationDatabase
    {
        /// <summary>
        /// 
        /// </summary>
        public string ServerAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DatabaseName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ConnectionString { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public ConfigurationDatabase()
        {
            ServerAddress = @".";
            DatabaseName = "MusicalPerformers";
            ConnectionString = $@"Data Source={ServerAddress}\SQLEXPRESS;Initial Catalog={DatabaseName};Integrated Security=True";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="serverAddress"></param>
        /// <param name="databaseName"></param>
        public ConfigurationDatabase(string serverAddress, string databaseName)
        {
            if(serverAddress == null ? true : serverAddress.Length == 0)
            {
                throw new ArgumentNullException("Адрес сервера не может быть пустым или длиной 0 символов.");
            }

            if(databaseName == null ? true : databaseName.Length == 0)
            {
                throw new ArgumentNullException("Название базы данных не может быть пустым или длиной 0 символов.");
            }

            ServerAddress = serverAddress;
            DatabaseName = databaseName;
            ConnectionString = $@"Data Source={ServerAddress}\SQLEXPRESS;Initial Catalog={DatabaseName};Integrated Security=True";
        }

        /// <summary>
        /// 
        /// </summary>
        public void Save()
        {
            JsonSerializator.GetInstance().Save(this, "ConfigurationDatabase.json");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        public void Save(string path)
        {
            if(path == null ? true : path.Length == 0)
            {
                throw new ArgumentNullException("Путь к файлу не может быть пустым или длиной 0 символов.");
            }

            JsonSerializator.GetInstance().Save(this, path);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "ConfigurationDatabase";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static ConfigurationDatabase GetConfiguration()
        {
            if(File.Exists("ConfigurationDatabase.json"))
            {
                var obj = JsonSerializator.GetInstance().Load<ConfigurationDatabase>("ConfigurationDatabase.json");

                if(obj is ConfigurationDatabase)
                {
                    return obj as ConfigurationDatabase;
                }
                else
                {
                    throw new InvalidObjectTypeException("Выходной тип объекта не соответствует ожидаемому.");
                }
            }
            else
            {
                throw new FileNotFoundException("Файл конфигурации не был найден.");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static ConfigurationDatabase GetConfiguration(string path)
        {
            if (File.Exists(path))
            {
                var obj = JsonSerializator.GetInstance().Load<ConfigurationDatabase>(path);

                if (obj is ConfigurationDatabase)
                {
                    return obj as ConfigurationDatabase;
                }
                else
                {
                    throw new InvalidObjectTypeException("Выходной тип объекта не соответствует ожидаемому.");
                }
            }
            else
            {
                throw new FileNotFoundException("Файл конфигурации не был найден.");
            }
        }
    }
}

using MusicalPerformers.Model.Exceptions;
using MusicalPerformers.Model.Serialization;
using System;
using System.IO;

namespace MusicalPerformers.Model.Configurations
{
    /// <summary>
    /// Класс, предназначенный для конфигурирования настроек базы данных.
    /// </summary>
    public class ConfigurationDatabase
    {
        /// <summary>
        /// Адрес сервера базы данных.
        /// </summary>
        private string _serverAddress;
        /// <summary>
        /// Название базы данных.
        /// </summary>
        private string _databaseName;

        /// <summary>
        /// Адрес сервера базы данных.
        /// </summary>
        public string ServerAddress
        {
            get { return _serverAddress; }
            set
            {
                _serverAddress = value;

                ConnectionString = GenerateConnectionString();
            }
        }

        /// <summary>
        /// Название базы данных.
        /// </summary>
        public string DatabaseName
        {
            get { return _databaseName; }
            set
            {
                _databaseName = value;

                ConnectionString = GenerateConnectionString();
            }
        }

        /// <summary>
        /// Строка подключения к базе данных.
        /// </summary>
        public string ConnectionString { get; private set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса ConfigurationDatabase.
        /// </summary>
        public ConfigurationDatabase()
        {
            ServerAddress = @".";
            DatabaseName = "MusicalPerformers";
            ConnectionString = GenerateConnectionString();
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса ConfigurationDatabase.
        /// </summary>
        /// <param name="serverAddress">Адрес сервера базы данных.</param>
        /// <param name="databaseName">Название базы данных.</param>
        public ConfigurationDatabase(string serverAddress, string databaseName)
        {
            if(serverAddress == null ? true : serverAddress.Length == 0)
            {
                throw new ArgumentNullException("serverAddress", "Адрес сервера не может быть пустым или длиной 0 символов.");
            }

            if(databaseName == null ? true : databaseName.Length == 0)
            {
                throw new ArgumentNullException("databaseName", "Название базы данных не может быть пустым или длиной 0 символов.");
            }

            ServerAddress = serverAddress;
            DatabaseName = databaseName;
            ConnectionString = GenerateConnectionString();
        }

        /// <summary>
        /// Сохраняет конфигурацию в файл.
        /// </summary>
        public void Save()
        {
            JsonSerializator.GetInstance().Save(this, "ConfigurationDatabase.json");
        }

        /// <summary>
        /// Сохраняет конфигурацию в файл.
        /// </summary>
        /// <param name="path">Путь к файлу для сохранения.</param>
        public void Save(string path)
        {
            if(path == null ? true : path.Length == 0)
            {
                throw new ArgumentNullException("path", "Путь к файлу не может быть пустым или длиной 0 символов.");
            }

            JsonSerializator.GetInstance().Save(this, path);
        }

        /// <summary>
        /// Возвращает строку, представляющую текущий объект.
        /// </summary>
        /// <returns>Cтрока, представляющий текущий объект.</returns>
        public override string ToString()
        {
            return "ConfigurationDatabase";
        }

        /// <summary>
        /// Получение конфигурации базы данных.
        /// </summary>
        /// <returns>Конфигурация базы данных.</returns>
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
                    var config = new ConfigurationDatabase();
                    config.Save();

                    return config;
                }
            }
            else
            {
                throw new FileNotFoundException("Файл конфигурации не был найден.", "ConfigurationDatabase.json");
            }
        }

        /// <summary>
        /// Получение конфигурации базы данных.
        /// </summary>
        /// <param name="path">Путь к расположению файла конфигурации базы данных.</param>
        /// <returns>Конфигурация базы данных.</returns>
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
                throw new FileNotFoundException("Файл конфигурации не был найден.", path);
            }
        }

        /// <summary>
        /// Генерирует строку подключения к базе данных.
        /// </summary>
        private string GenerateConnectionString()
        {
            return $@"Data Source={ServerAddress}\SQLEXPRESS;Initial Catalog={DatabaseName};Integrated Security=True";
        }
    }
}

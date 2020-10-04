using MusicalPerformers.Model.Exceptions;
using MusicalPerformers.Model.Serialization;
using System;
using System.IO;

namespace MusicalPerformers.Model.Configurations
{
    /// <summary>
    /// Класс, предназначенный для конфигурирования настроек пользователя.
    /// </summary>
    public class ConfigurationUser
    {
        #region Свойства
        /// <summary>
        /// Экземпляр объекта класса ConfigurationUser.
        /// </summary>
        private static ConfigurationUser _instance;

        /// <summary>
        /// Идентификационный номер пользователя.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Название должности.
        /// </summary>
        public string RoleName { get; set; }
        #endregion

        /// <summary>
        /// Инициализирует новый экземпляр класса QueryExecutor.
        /// </summary>
        /// <param name="userId">Идентификационный номер пользователя.</param>
        /// <param name="roleName">Название должности.</param>
        public ConfigurationUser(int userId, string roleName)
        {
            #region Проверка аргументов конструктора класса
            if (roleName == null ? true : roleName.Length == 0)
            {
                throw new ArgumentNullException("roleName", "Название должности не может быть пустым или длиной 0 символов.");
            }
            #endregion

            UserId = userId;
            RoleName = roleName;
        }

        /// <summary>
        /// Получение экземпляр объекта класса ConfigurationUser.
        /// </summary>
        /// <param name="userId">Идентификационный номер пользователя.</param>
        /// <param name="roleName">Название должности.</param>
        /// <returns>Экземпляр объекта класса ConfigurationUser.</returns>
        public static ConfigurationUser GetInstance(int userId, string roleName)
        {
            if (_instance == null)
            {
                _instance = new ConfigurationUser(userId, roleName);
            }

            return _instance;
        }

        /// <summary>
        /// Сохраняет конфигурацию в файл.
        /// </summary>
        public void Save()
        {
            JsonSerializator.GetInstance().Save(this, "ConfigurationUser.json");
        }

        /// <summary>
        /// Сохраняет конфигурацию в файл.
        /// </summary>
        /// <param name="path">Путь к файлу для сохранения.</param>
        public void Save(string path)
        {
            #region Проверка аргументов метода
            if (path == null ? true : path.Length == 0)
            {
                throw new ArgumentNullException("path", "Путь к файлу не может быть пустым или длиной 0 символов.");
            }
            #endregion

            JsonSerializator.GetInstance().Save(this, path);
        }

        /// <summary>
        /// Возвращает строку, представляющую текущий объект.
        /// </summary>
        /// <returns>Cтрока, представляющий текущий объект.</returns>
        public override string ToString()
        {
            return "ConfigurationUser";
        }

        /// <summary>
        /// Получение конфигурации пользователя.
        /// </summary>
        /// <returns>Конфигурация пользователя.</returns>
        public static ConfigurationUser GetConfiguration()
        {
            if (File.Exists("ConfigurationUser.json"))
            {
                var obj = JsonSerializator.GetInstance().Load<ConfigurationUser>("ConfigurationUser.json");

                if (obj is ConfigurationUser)
                {
                    return obj as ConfigurationUser;
                }
                else
                {
                    throw new InvalidObjectTypeException("Выходной тип объекта не соответствует ожидаемому.");
                }
            }
            else
            {
                throw new FileNotFoundException("Файл конфигурации не был найден.", "ConfigurationUser.json");
            }
        }

        /// <summary>
        /// Получение конфигурации пользователя.
        /// </summary>
        /// <param name="path">Путь к расположению файла конфигурации пользователя.</param>
        /// <returns>Конфигурация пользователя.</returns>
        public static ConfigurationUser GetConfiguration(string path)
        {
            if (File.Exists(path))
            {
                var obj = JsonSerializator.GetInstance().Load<ConfigurationUser>(path);

                if (obj is ConfigurationUser)
                {
                    return obj as ConfigurationUser;
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
    }
}

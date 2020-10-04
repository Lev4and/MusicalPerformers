using Newtonsoft.Json;
using System;
using System.IO;

namespace MusicalPerformers.Model.Serialization
{
    /// <summary>
    /// Класс, предназначенный для сериализации и десериализации экземпляров объектов класса, используя Json формат.
    /// </summary>
    public class JsonSerializator : Serializator
    {
        #region Свойства
        /// <summary>
        /// Экземпляр объекта класса JsonSerializator.
        /// </summary>
        private static JsonSerializator _instance;
        #endregion

        /// <summary>
        /// Инициализирует новый экземпляр класса JsonSerializator.
        /// </summary>
        private JsonSerializator() : base()
        {

        }

        /// <summary>
        /// Сериализует объект класса, сохраняя его в указанный путь, используя Json формат.
        /// </summary>
        /// <param name="obj">Объект класса.</param>
        /// <param name="path">Указанный путь для сохранения файла.</param>
        public override void Save(object obj, string path)
        {
            #region Проверка аргументов метода
            if (path == null ? true : path.Length == 0)
            {
                throw new ArgumentNullException("path", "Путь к файлу не может быть пустым или длиной 0 символов.");
            }
            #endregion

            File.WriteAllText(path, JsonConvert.SerializeObject(obj));
        }

        /// <summary>
        /// Десериализует объект класса, из указанного файла, используя Json формат.
        /// </summary>
        /// <param name="path">Путь расположения файла.</param>
        /// <returns>Возвращает десериализуемый объект класса.</returns>
        public override object Load(string path)
        {
            #region Проверка аргументов метода
            if (path == null ? true : path.Length == 0)
            {
                throw new ArgumentNullException("path", "Путь к файлу не может быть пустым или длиной 0 символов.");
            }
            #endregion

            if (File.Exists(path))
            {
                return JsonConvert.DeserializeObject(File.ReadAllText(path));
            }
            else
            {
                throw new FileNotFoundException("Файл не был найден.", path);
            }
        }

        /// <summary>
        /// Десериализует объект класса, из указанного файла.
        /// </summary>
        /// <typeparam name="T">Возвращаемый тип данных.</typeparam>
        /// <param name="path">Путь расположения файла.</param>
        /// <returns>Возвращает десериализуемый объект класса.</returns>
        public override T Load<T>(string path)
        {
            #region Проверка аргументов метода
            if (path == null ? true : path.Length == 0)
            {
                throw new ArgumentNullException("path", "Путь к файлу не может быть пустым или длиной 0 символов.");
            }
            #endregion

            if (File.Exists(path))
            {
                return JsonConvert.DeserializeObject<T>(File.ReadAllText(path));
            }
            else
            {
                throw new FileNotFoundException("Файл не был найден.", path);
            }
        }

        /// <summary>
        /// Получение экземпляр объекта класса JsonSerializator.
        /// </summary>
        /// <returns>Экземпляр объекта класса JsonSerializator.</returns>
        public static JsonSerializator GetInstance()
        {
            if(_instance == null)
            {
                _instance = new JsonSerializator();
            }

            return _instance;
        }
    }
}

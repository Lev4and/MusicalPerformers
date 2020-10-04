namespace MusicalPerformers.Model.Serialization
{
    /// <summary>
    /// Класс, предназначенный для сериализации и десериализации экземпляров объектов класса.
    /// </summary>
    public abstract class Serializator
    {
        /// <summary>
        /// Сериализует объект класса, сохраняя его в указанный путь.
        /// </summary>
        /// <param name="obj">Объект класса.</param>
        /// <param name="path">Указанный путь для сохранения файла.</param>
        public abstract void Save(object obj, string path);

        /// <summary>
        /// Десериализует объект класса, из указанного файла. 
        /// </summary>
        /// <param name="path">Путь расположения файла.</param>
        /// <returns>Возвращает десериализуемый объект класса.</returns>
        public abstract object Load(string path);

        /// <summary>
        /// Десериализует объект класса, из указанного файла.
        /// </summary>
        /// <typeparam name="T">Возвращаемый тип данных.</typeparam>
        /// <param name="path">Путь расположения файла.</param>
        /// <returns>Возвращает десериализуемый объект класса.</returns>
        public abstract T Load<T>(string path);
    }
}

using System;

namespace MusicalPerformers.Model.Formatters.Parsers
{
    /// <summary>
    /// Класс, предназначенный для парсинга пути расположения файла.
    /// </summary>
    public class PathParser
    {
        /// <summary>
        /// Определяет, соответствует ли файл к заданному расширению. 
        /// </summary>
        /// <param name="path">Путь расположения файла.</param>
        /// <param name="extension">Расширение файла.</param>
        /// <returns>Возвращает значение true, если файл соответствует заданному расширению, иначе false.</returns>
        public static bool IsCorrectExtension(string path, string extension)
        {
            if (path == null || path != null ? path.Length == 0 : false)
            {
                throw new ArgumentNullException("path", "Путь к файлу не может быть пустым или длиной 0 символов.");
            }

            if (extension == null || extension != null ? extension.Length == 0 : false)
            {
                throw new ArgumentNullException("extension", "Расширение файла не может быть пустым или длиной 0 символов.");
            }

            return path.EndsWith(extension);
        }

        /// <summary>
        /// Определяет, соответствует ли файл к заданными расширениями.
        /// </summary>
        /// <param name="path">Путь расположения файла.</param>
        /// <param name="extensions">Расширения файлов.</param>
        /// <returns>Возвращает значение true, если файл соответствует к одному из заданных расширений, иначе false.</returns>
        public static bool IsCorrectExtension(string path, string[] extensions)
        {
            if (path == null || path != null ? path.Length == 0 : false)
            {
                throw new ArgumentNullException("path", "Путь к файлу не может быть пустым или длиной 0 символов.");
            }

            if (extensions == null || extensions != null ? extensions.Length == 0 : false)
            {
                throw new ArgumentNullException("extensions", "Массив расширений файлов оказался пустым или его длина имела 0 элементов.");
            }

            for (int i = 0; i < extensions.Length; i++)
            {
                if (IsCorrectExtension(path, extensions[i]))
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Получает название файла.
        /// </summary>
        /// <param name="path">Путь расположения файла.</param>
        /// <returns></returns>
        public static string GetFileName(string path)
        {
            if (path == null || path != null ? path.Length == 0 : false)
            {
                throw new ArgumentNullException("path", "Путь к файлу не может быть пустым или длиной 0 символов.");
            }

            return path.Substring(path.LastIndexOfAny(new char[2] { @"\"[0], '/' }) + 1, path.LastIndexOf('.') - path.LastIndexOfAny(new char[2] { @"\"[0], '/' }) - 1);
        }

        /// <summary>
        /// Получает расширение файла.
        /// </summary>
        /// <param name="path">Путь расположения файла.</param>
        /// <returns></returns>
        public static string GetFileExtension(string path)
        {
            if (path == null || path != null ? path.Length == 0 : false)
            {
                throw new ArgumentNullException("path", "Путь к файлу не может быть пустым или длиной 0 символов.");
            }

            return path.Substring(path.LastIndexOf('.'));
        }

        /// <summary>
        /// Получает название файла с её расширением.
        /// </summary>
        /// <param name="path">Путь расположения файла.</param>
        /// <returns></returns>
        public static string GetFileNameWithExtension(string path)
        {
            if (path == null || path != null ? path.Length == 0 : false)
            {
                throw new ArgumentNullException("path", "Путь к файлу не может быть пустым или длиной 0 символов.");
            }

            return path.Substring(path.LastIndexOfAny(new char[2] { @"\"[0], '/' }) + 1);
        }
    }
}

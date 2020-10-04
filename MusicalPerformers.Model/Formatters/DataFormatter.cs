using System;
using System.Data;

namespace MusicalPerformers.Model.Formatters
{
    /// <summary>
    /// Класс, предназначенный для извлечения определенных данных из результата выполнения запроса.
    /// </summary>
    public static class DataFormatter
    {
        /// <summary>
        /// Извлечение определенных данных из указанного источника.
        /// </summary>
        /// <typeparam name="T">Тип возвращаемого значения.</typeparam>
        /// <param name="source">Источник данных.</param>
        /// <param name="columnName">Названия столбика.</param>
        /// <returns>Возвращает значение ячейки из указанного источника и названия столбика. Возвращаемое значение извлекается из первой строки источника данных.</returns>
        public static T GetValue<T>(DataTable source, string columnName)
        {
            #region Проверка аргументов метода
            if (source == null)
            {
                throw new ArgumentNullException("source", "Источник данных не должен быть пустым");
            }

            if(columnName == null ? true : columnName.Length == 0)
            {
                throw new ArgumentNullException("columnName", "Название столбика не должно быть нулевым или длиной 0 символов.");
            }
            #endregion

            return source.Rows[0].Field<T>(columnName);
        }

        /// <summary>
        /// Извлечение определенных данных из указанного источника.
        /// </summary>
        /// <typeparam name="T">Тип возвращаемого значения.</typeparam>
        /// <param name="source">Источник данных.</param>
        /// <param name="columnName">Названия столбика.</param>
        /// <param name="rowIndex">Номер строки отсчитываемый от нуля.</param>
        /// <returns>Возвращает значение ячейки из определённой строки, указанного источника и названия столбика.</returns>
        public static T GetValue<T>(DataTable source, string columnName, int rowIndex)
        {
            #region Проверка аргументов метода
            if (source == null)
            {
                throw new ArgumentNullException("source", "Источник данных не должен быть пустым");
            }

            if (columnName == null ? true : columnName.Length == 0)
            {
                throw new ArgumentNullException("columnName", "Название столбика не должно быть нулевым или длиной 0 символов.");
            }

            if(rowIndex < 0 || rowIndex + 1 > source.Rows.Count)
            {
                throw new IndexOutOfRangeException("Индекс находится за пределами массива.");
            }
            #endregion

            return source.Rows[rowIndex].Field<T>(columnName);
        }
    }
}

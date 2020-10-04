using System;

namespace MusicalPerformers.Model.Exceptions
{
    /// <summary>
    /// Это исключение срабатывает, если объект класса не соответствует определенному типу.
    /// </summary>
    public class InvalidObjectTypeException : Exception
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса InvalidObjectTypeException.
        /// </summary>
        /// <param name="message">Сообщение о причине, указывающее причину исключения.</param>
        public InvalidObjectTypeException(string message) : base(message)
        {
            #region Проверка аргументов конструктора
            if (message == null ? true : message.Length == 0)
            {
                throw new ArgumentNullException("message", "Сообщение о причине не может быть пустым или длиной 0 символов.");
            }
            #endregion
        }
    }
}

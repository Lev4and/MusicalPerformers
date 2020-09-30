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
            if (message == null ? true : message.Length == 0)
            {
                throw new ArgumentNullException("Сообщение о причине не может быть пустым или длиной 0 символов.");
            }
        }
    }
}

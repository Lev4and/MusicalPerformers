using System;

namespace MusicalPerformers.Model.Exceptions
{
    /// <summary>
    /// Это исключение срабатывает, если расширение файла имел неверный формат.
    /// </summary>
    public class InvalidFileExtensionException : Exception
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса InvalidFileExtensionException.
        /// </summary>
        /// <param name="message">Сообщение о причине, указывающее причину исключения.</param>
        public InvalidFileExtensionException(string message) : base(message)
        {
            if(message == null ? true : message.Length == 0)
            {
                throw new ArgumentNullException("message", "Сообщение о причине не может быть пустым или длиной 0 символов.");
            }
        }
    }
}

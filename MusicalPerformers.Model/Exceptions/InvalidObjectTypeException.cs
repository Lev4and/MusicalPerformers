using System;

namespace MusicalPerformers.Model.Exceptions
{
    /// <summary>
    /// 
    /// </summary>
    public class InvalidObjectTypeException : Exception
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public InvalidObjectTypeException(string message) : base(message)
        {
            if (message == null ? true : message.Length == 0)
            {
                throw new ArgumentNullException("Сообщение о причине не может быть пустым или длиной 0 символов.");
            }
        }
    }
}

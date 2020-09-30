namespace MusicalPerformers.Model.Database.Interactions.DataActions
{
    /// <summary>
    /// Интерфейс, описывающий запросы к базе данных, необходимые для проверки на существования данных.
    /// </summary>
    public interface IContainsable
    {
        /// <summary>
        /// Проверка на существование пользователя.
        /// </summary>
        /// <param name="userId">Идентификационный номер пользователя.</param>
        /// <returns>Возвращает True, если были обнаружены совпадения, иначе False.</returns>
        bool ContainsUser(int userId);

        /// <summary>
        /// Проверка на существование пользователя.
        /// </summary>
        /// <param name="login">Логин.</param>
        /// <returns>Возвращает True, если были обнаружены совпадения, иначе False.</returns>
        bool ContainsUser(string login);
    }
}

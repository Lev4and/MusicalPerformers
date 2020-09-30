namespace MusicalPerformers.Model.Database.Interactions.DataActions
{
    /// <summary>
    /// Интерфейс, описывающий запросы к базе данных, необходимые для выполнения функциональных задач.
    /// </summary>
    public interface IFunctionable
    {
        /// <summary>
        /// Процесс авторизации пользователя.
        /// </summary>
        /// <param name="login">Логин.</param>
        /// <param name="password">Пароль.</param>
        /// <returns>Возвращает True, если пользователь ввел верный логин и пароль, иначе False.</returns>
        bool UserAuthorization(string login, string password);
    }
}

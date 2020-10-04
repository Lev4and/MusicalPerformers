namespace MusicalPerformers.Model.Database.Interactions.DataActions
{
    /// <summary>
    /// Интерфейс, описывающий запросы к базе данных, необходимые для добавления новых данных.
    /// </summary>
    public interface IAddable
    {
        /// <summary>
        /// Добавление нового пользователя в базу данных.
        /// </summary>
        /// <param name="roleId">Идентификационный номер должности.</param>
        /// <param name="login">Логин.</param>
        /// <param name="password">Пароль.</param>
        /// <param name="avatar">Аватар.</param>
        /// <returns>Возвращает True, если база данных успешно добавила новую запись, иначе False, если пользователь с таким логином уже существует.</returns>
        bool AddUser(int roleId, string login, string password, byte[] avatar);

        /// <summary>
        /// Добавление нового жанра в базу данных.
        /// </summary>
        /// <param name="name">Название жанра.</param>
        /// <returns>Возвращает True, если база данных успешно добавила новую запись, иначе False, если жанр с таким названием уже существует.</returns>
        bool AddGenre(string name);
    }
}

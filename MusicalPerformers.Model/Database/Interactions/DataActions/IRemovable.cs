namespace MusicalPerformers.Model.Database.Interactions.DataActions
{
    /// <summary>
    /// Интерфейс, описывающий запросы к базе данных, необходимые для удаления данных.
    /// </summary>
    public interface IRemovable
    {
        /// <summary>
        /// Удаление пользователя из базы данных.
        /// </summary>
        /// <param name="userId">Идентификационный номер пользователя.</param>
        void RemoveUser(int userId);

        /// <summary>
        /// Удаление пользователя из базы данных.
        /// </summary>
        /// <param name="login">Логин.</param>
        void RemoveUser(string login);

        /// <summary>
        /// Удаление жанра из базы данных.
        /// </summary>
        /// <param name="genreId">Идентификационный номер жанра.</param>
        void RemoveGenre(int genreId);

        /// <summary>
        /// Удаление жанра из базы данных.
        /// </summary>
        /// <param name="genreName">название жанра.</param>
        void RemoveGenre(string genreName);
    }
}

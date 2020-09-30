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
    }
}

namespace MusicalPerformers.Model.Database.Interactions.DataActions
{
    /// <summary>
    /// Интерфейс, описывающий запросы к базе данных, необходимые для обновления данных.
    /// </summary>
    public interface IUpdatable
    {
        /// <summary>
        /// Обновление данных о жанре.
        /// </summary>
        /// <param name="genreId">Идентификационный номер жанра.</param>
        /// <param name="genreName">Название жанра.</param>
        /// <returns>Возвращает True, если база данных успешно обновила запись, иначе False, если жанр с таким названием уже существует.</returns>
        bool UpdateGenre(int genreId, string genreName);
    }
}

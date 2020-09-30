using MusicalPerformers.Model.Database.Interactions.DataActions;
using System.Data;
using System.Data.SqlClient;

namespace MusicalPerformers.Model.Database.Interactions
{
    /// <summary>
    /// Интерфейс, описывающий способы обращения к базе данных SQL Server.
    /// </summary>
    public interface IInteraction : IAccordanable, IAddable, IContainsable, IFunctionable, IGetable, IProcedurable, IRemovable, IUpdatable
    {
        /// <summary>
        /// Подключение к базе данных SQL Server.
        /// </summary>
        SqlConnection Connection { get; set; }

        /// <summary>
        /// Доступ к пользовательским данным.
        /// </summary>
        SqlDataAdapter DataAdapter { get; set; }

        /// <summary>
        /// Выполнение запроса в SQL Server.
        /// </summary>
        /// <param name="query">Запрос к базе данных на языке T-SQL.</param>
        /// <param name="parameters">Параметры, необходимые для подстановки значений в запросе.</param>
        void ExecuteQuery(string query, SqlParameter[] parameters);

        /// <summary>
        /// Выполнение запроса в SQL Server.
        /// </summary>
        /// <param name="query">Запрос к базе данных на языке T-SQL.</param>
        /// <returns>Результат выполнения запроса.</returns>
        DataTable ExecuteQuery(string query);
    }
}

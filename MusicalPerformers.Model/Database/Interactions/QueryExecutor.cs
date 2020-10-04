using MusicalPerformers.Model.Configurations;
using System;
using System.Data;
using System.Data.SqlClient;

namespace MusicalPerformers.Model.Database.Interactions
{
    /// <summary>
    /// Класс, предназначенный для выполнения запросов к базе данных и получения его результата.
    /// </summary>
    public class QueryExecutor : IInteraction
    {
        /// <summary>
        /// Экземпляр объекта класса QueryExecutor.
        /// </summary>
        private static QueryExecutor _instance;

        /// <summary>
        /// Инициализирует новый экземпляр класса QueryExecutor.
        /// </summary>
        private QueryExecutor()
        {
            Connection = new SqlConnection(ConfigurationDatabase.GetConfiguration().ConnectionString);
            DataAdapter = new SqlDataAdapter();
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса QueryExecutor.
        /// </summary>
        /// <param name="configDb">Конфигурация базы данных.</param>
        private QueryExecutor(ConfigurationDatabase configDb)
        {
            Connection = new SqlConnection(configDb.ConnectionString);
            DataAdapter = new SqlDataAdapter();
        }

        /// <summary>
        /// Подключение к базе данных SQL Server.
        /// </summary>
        public SqlConnection Connection { get; set; }

        /// <summary>
        /// Доступ к пользовательским данным.
        /// </summary>
        public SqlDataAdapter DataAdapter { get; set; }
        /// <summary>
        /// Получение экземпляр объекта класса QueryExecutor.
        /// </summary>
        /// <returns>Экземпляр объекта класса QueryExecutor.</returns>
        public static QueryExecutor GetInstance()
        {
            if (_instance == null)
            {
                _instance = new QueryExecutor();
            }

            return _instance;
        }

        /// <summary>
        /// Получение экземпляр объекта класса QueryExecutor.
        /// </summary>
        /// <param name="configDb">Конфигурация базы данных.</param>
        /// <returns>Экземпляр объекта класса QueryExecutor.</returns>
        public static QueryExecutor GetInstance(ConfigurationDatabase configDb)
        {
            if (_instance == null)
            {
                _instance = new QueryExecutor(configDb);
            }

            return _instance;
        }

        /// <summary>
        /// Добавление нового пользователя в базу данных.
        /// </summary>
        /// <param name="roleId">Идентификационный номер должности.</param>
        /// <param name="login">Логин.</param>
        /// <param name="password">Пароль.</param>
        /// <param name="avatar">Аватар.</param>
        /// <returns>Возвращает True, если база данных успешно добавила новую запись, иначе False, если пользователь с таким логином уже существует.</returns>
        public bool AddUser(int roleId, string login, string password, byte[] avatar)
        {
            if (!ContainsUser(login))
            {
                string query = $"INSERT INTO [user] " +
                               $"([user].[role_id], [user].[login], [user].[password], [user].[date_of_registration], [user].[avatar]) " +
                               $"VALUES ({roleId}, '{login}', '{password}', '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:dd")}', @avatar)";

                ExecuteQuery(query, new SqlParameter[] 
                { 
                    new SqlParameter("@avatar", SqlDbType.VarBinary) { Value = GetValueParameter(avatar) }
                });

                return true;
            }

            return false;
        }

        /// <summary>
        /// Проверка на существование пользователя.
        /// </summary>
        /// <param name="login">Логин.</param>
        /// <returns>Возвращает True, если были обнаружены совпадения, иначе False.</returns>
        public bool ContainsUser(string login)
        {
            string query = $"SELECT TOP (1) * FROM [user] WHERE [user].[login] = '{login}'";

            return ExecuteQuery(query).Rows.Count > 0;
        }

        /// <summary>
        /// Проверка на существование пользователя.
        /// </summary>
        /// <param name="userId">Идентификационный номер пользователя.</param>
        /// <returns>Возвращает True, если были обнаружены совпадения, иначе False.</returns>
        public bool ContainsUser(int userId)
        {
            string query = $"SELECT TOP (1) * FROM [user] WHERE [user].[user_id] = {userId}";

            return ExecuteQuery(query).Rows.Count > 0;
        }

        /// <summary>
        /// Выполнение запроса в SQL Server.
        /// </summary>
        /// <param name="query">Запрос к базе данных на языке T-SQL.</param>
        /// <returns>Результат выполнения запроса.</returns>
        public DataTable ExecuteQuery(string query)
        {
            if (query == null ? true : query.Length == 0)
            {
                throw new ArgumentNullException("query", "Запрос к базе данных не может быть пустым или длиной 0 символов.");
            }

            var result = new DataTable();

            DataAdapter = new SqlDataAdapter(query, Connection);
            DataAdapter.Fill(result);

            return result;
        }

        /// <summary>
        /// Выполнение запроса в SQL Server.
        /// </summary>
        /// <param name="query">Запрос к базе данных на языке T-SQL.</param>
        /// <param name="parameters">Параметры, необходимые для подстановки значений в запросе.</param>
        public void ExecuteQuery(string query, SqlParameter[] parameters)
        {
            var command = new SqlCommand(query, Connection);
            command.Parameters.AddRange(parameters);

            Connection.Open();
            command.ExecuteNonQuery();
            Connection.Close();
        }

        /// <summary>
        /// Получение идентификационного номера должности по указанному названию.
        /// </summary>
        /// <param name="roleName">Название должности.</param>
        /// <returns>Возвращает идентификационный номер должности.</returns>
        public int GetRoleId(string roleName)
        {
            if (roleName == null ? true : roleName.Length == 0)
            {
                throw new ArgumentNullException("roleName", "Название должности не может быть пустым или длиной 0 символов.");
            }

            string query = $"SELECT [role].[role_id] FROM [role] WHERE [role].[name] = '{roleName}'";

            return ExecuteQuery(query).Rows[0].Field<int>("role_id");
        }

        /// <summary>
        /// Получение всех должностей.
        /// </summary>
        /// <returns>Возвращает все существующие должности, находящиеся в базе данных.</returns>
        public DataTable GetRoles()
        {
            string query = $"SELECT * FROM [role]";

            return ExecuteQuery(query);
        }

        /// <summary>
        /// Получение пользовательской информации.
        /// </summary>
        /// <param name="userId">Идентификационный номер пользователя.</param>
        /// <returns>Информация о пользователе.</returns>
        public DataTable GetUserInformation(int userId)
        {
            string query = $"SELECT [user].[user_id], " +
                           $"[role].[role_id], " +
                           $"[role].[name] AS [role_name], " +
                           $"[user].[login]," +
                           $"[user].[password]," +
                           $"[user].[date_of_registration]," +
                           $"[user].[avatar]" +
                           $"FROM [user] INNER JOIN " +
                           $"[role] ON [role].[role_id] = [user].[role_id] " +
                           $"WHERE [user].[user_id] = {userId}";

            return ExecuteQuery(query);       
        }

        /// <summary>
        /// Получение пользовательской информации.
        /// </summary>
        /// <param name="login">Логин.</param>
        /// <returns>Информация о пользователе.</returns>
        public DataTable GetUserInformation(string login)
        {
            string query = $"SELECT [user].[user_id], " +
                           $"[role].[role_id], " +
                           $"[role].[name] AS [role_name], " +
                           $"[user].[login]," +
                           $"[user].[password]," +
                           $"[user].[date_of_registration]," +
                           $"[user].[avatar]" +
                           $"FROM [user] INNER JOIN " +
                           $"[role] ON [role].[role_id] = [user].[role_id] " +
                           $"WHERE [user].[login] = '{login}'";

            return ExecuteQuery(query);
        }

        /// <summary>
        /// Получение значения для свойтва Value класса SqlParameter.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <returns>Возвращает объект если он не пустой, иначе DBNull.Value</returns>
        public object GetValueParameter(object value)
        {
            return value != null ? value : DBNull.Value;
        }

        /// <summary>
        /// Удаление пользователя из базы данных.
        /// </summary>
        /// <param name="userId">Идентификационный номер пользователя.</param>
        public void RemoveUser(int userId)
        {
            string query = $"DELETE " +
                           $"FROM [user] " +
                           $"WHERE [user].[user_id] = {userId}";

            ExecuteQuery(query);
        }

        /// <summary>
        /// Удаление пользователя из базы данных.
        /// </summary>
        /// <param name="login">Логин.</param>
        public void RemoveUser(string login)
        {
            if (login == null ? true : login.Length == 0)
            {
                throw new ArgumentNullException("login", "Логин не может быть пустым или длиной 0 символов.");
            }

            string query = $"DELETE " +
                           $"FROM [user] " +
                           $"WHERE [user].[login] = '{login}'";

            ExecuteQuery(query);
        }
        /// <summary>
        /// Процесс авторизации пользователя.
        /// </summary>
        /// <param name="login">Логин.</param>
        /// <param name="password">Пароль.</param>
        /// <returns>Возвращает True, если пользователь ввел верный логин и пароль, иначе False.</returns>
        public bool UserAuthorization(string login, string password)
        {
            if (login == null ? true : login.Length == 0)
            {
                throw new ArgumentNullException("login", "Логин не может быть пустым или длиной 0 символов.");
            }

            if (password == null ? true : password.Length == 0)
            {
                throw new ArgumentNullException("password", "Пароль не может быть пустым или длиной 0 символов.");
            }

            string query = $"SELECT TOP (1) * " +
                           $"FROM [user] " +
                           $"WHERE [user].[login] = '{login}' AND [user].[password] = '{password}'";

            return ExecuteQuery(query).Rows.Count > 0;
        }
    }
}

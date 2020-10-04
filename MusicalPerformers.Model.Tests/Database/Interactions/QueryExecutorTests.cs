using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicalPerformers.Model.Configurations;
using MusicalPerformers.Model.Database.Interactions;
using System;
using System.Diagnostics;

namespace MusicalPerformers.Model.Tests.Database.Interactions
{
    /// <summary>
    /// Тестирование класса QueryExecutor.
    /// </summary>
    [TestClass]
    public class QueryExecutorTests
    {
        /// <summary>
        /// Инициализация теста.
        /// </summary>
        [TestInitialize]
        public void Initialize()
        {
            QueryExecutor.GetInstance(new ConfigurationDatabase()).RemoveUser("User");
            QueryExecutor.GetInstance(new ConfigurationDatabase()).RemoveGenre("TestGenre2020");
            QueryExecutor.GetInstance(new ConfigurationDatabase()).RemoveGenre("TestGenre2020_1");
        }

        /// <summary>
        /// Тестирует метод ContainsUser класса QueryExecutor.
        /// </summary>
        [TestMethod]
        public void ContainsUser_Login_TrueReturned()
        {
            bool expected = true;
            bool actual = QueryExecutor.GetInstance().ContainsUser("Admin");

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тестирует метод ContainsUser класса QueryExecutor.
        /// </summary>
        [TestMethod]
        public void ContainsUser_Login_FalseReturned()
        {
            bool expected = false;
            bool actual = QueryExecutor.GetInstance().ContainsUser("User");

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тестирует метод GetRoleId класса QueryExecutor.
        /// </summary>
        [TestMethod]
        public void GetRoleId_RoleName_NumberReturned()
        {
            QueryExecutor.GetInstance().GetRoleId("Администратор");
        }

        /// <summary>
        /// Тестирует метод GetRoleId класса QueryExecutor.
        /// </summary>
        [TestMethod]
        public void GetRoleId_RoleName_ExceptionReturned()
        {
            Exception exception = null;

            try
            {
                QueryExecutor.GetInstance().GetRoleId("Владелец");
            }
            catch(Exception e)
            {
                exception = e;
            }

            Assert.IsNotNull(exception);
        }

        /// <summary>
        /// Тестирует метод AddUser класса QueryExecutor.
        /// </summary>
        [TestMethod]
        public void AddUser_TrueReturned()
        {
            bool expected = true;
            bool actual = QueryExecutor.GetInstance().AddUser(QueryExecutor.GetInstance().GetRoleId("Пользователь"), "User", "123", null);

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тестирует метод AddUser класса QueryExecutor.
        /// </summary>
        [TestMethod]
        public void AddUser_FalseReturned()
        {
            bool expected = false;
            bool actual = QueryExecutor.GetInstance().AddUser(QueryExecutor.GetInstance().GetRoleId("Администратор"), "Admin", "123", null);

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тестирует метод GetValueParameter класса QueryExecutor.
        /// </summary>
        [TestMethod]
        public void GetValueParameter_Null_DBNullReturned()
        {
            object expected = DBNull.Value;
            object actual = QueryExecutor.GetInstance().GetValueParameter(null);

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тестирует метод GetValueParameter класса QueryExecutor.
        /// </summary>
        [TestMethod]
        public void GetValueParameter_Object_ObjectReturned()
        {
            object obj = "Object";

            object expected = obj;
            object actual = QueryExecutor.GetInstance().GetValueParameter(obj);

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тестирует метод GetRoles класса QueryExecutor.
        /// </summary>
        [TestMethod]
        public void GetRoles_RolesReturned()
        {
            var result = QueryExecutor.GetInstance().GetRoles();

            Debug.WriteLine($"Количество отобранных строк - {result.Rows.Count}");
        }

        /// <summary>
        /// Тестирует метод GetUserInformation класса QueryExecutor.
        /// </summary>
        [TestMethod]
        public void GetUserInformation_UserId()
        {
            var result = QueryExecutor.GetInstance().GetUserInformation(1);

            Debug.WriteLine($"Количество отобранных строк - {result.Rows.Count}");
        }

        /// <summary>
        /// Тестирует метод ContainsUser класса QueryExecutor.
        /// </summary>
        [TestMethod]
        public void ContainsUser_UserId_TrueReturned()
        {
            bool expected = true;
            bool actual = QueryExecutor.GetInstance().ContainsUser(1);

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тестирует метод ContainsUser класса QueryExecutor.
        /// </summary>
        [TestMethod]
        public void ContainsUser_UserId_FalseReturned()
        {
            bool expected = false;
            bool actual = QueryExecutor.GetInstance().ContainsUser(0);

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тестирует метод UserAuthorization класса QueryExecutor.
        /// </summary>
        [TestMethod]
        public void UserAuthorization_LoginAndPassword_TrueReturned()
        {
            bool expected = true;
            bool actual = QueryExecutor.GetInstance().UserAuthorization("Admin", "123");

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тестирует метод UserAuthorization класса QueryExecutor.
        /// </summary>
        [TestMethod]
        public void UserAuthorization_LoginAndPassword_FalseReturned()
        {
            bool expected = false;
            bool actual = QueryExecutor.GetInstance().UserAuthorization("Admin", "1234");

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тестирует метод Genres класса QueryExecutor.
        /// </summary>
        [TestMethod]
        public void GetGenres_Name_GenresReturned()
        {
            var result = QueryExecutor.GetInstance().GetGenres("рок");

            Debug.WriteLine($"Количество отобранных строк - {result.Rows.Count}");
        }

        /// <summary>
        /// Тестирует метод Genres класса QueryExecutor.
        /// </summary>
        [TestMethod]
        public void GetGenres_Name_ExceptionReturned()
        {
            try
            {
                var result = QueryExecutor.GetInstance().GetGenres(null);
            }
            catch(Exception ex)
            {
                Assert.IsNotNull(ex);
            }
        }

        /// <summary>
        /// Тестирует метод AddGenre класса QueryExecutor.
        /// </summary>
        [TestMethod]
        public void AddGenre_Name_FalseReturned()
        {
            bool expected = false;
            bool actual = QueryExecutor.GetInstance().AddGenre("K-pop");

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тестирует метод AddGenre класса QueryExecutor.
        /// </summary>
        [TestMethod]
        public void AddGenre_Name_TrueReturned()
        {
            bool expected = true;
            bool actual = QueryExecutor.GetInstance().AddGenre("TestGenre2020");

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тестирует метод ContainsGenre класса QueryExecutor.
        /// </summary>
        [TestMethod]
        public void ContainsGenre_Name_FalseReturned()
        {
            bool expected = false;
            bool actual = QueryExecutor.GetInstance().ContainsGenre("TestGenre2020");

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тестирует метод ContainsGenre класса QueryExecutor.
        /// </summary>
        [TestMethod]
        public void ContainsGenre_Name_TrueReturned()
        {
            bool expected = true;
            bool actual = QueryExecutor.GetInstance().ContainsGenre("K-pop");

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тестирует метод GetGenre класса QueryExecutor.
        /// </summary>
        [TestMethod]
        public void GetGenre_GenreId_MoreZeroRowsReturned()
        {
            Assert.IsTrue(QueryExecutor.GetInstance().GetGenre(2).Rows.Count > 0);
        }

        /// <summary>
        /// Тестирует метод GetGenre класса QueryExecutor.
        /// </summary>
        [TestMethod]
        public void GetGenre_GenreId_ZeroRowsReturned()
        {
            Assert.IsTrue(QueryExecutor.GetInstance().GetGenre(0).Rows.Count == 0);
        }

        /// <summary>
        /// Тестирует метод UpdateGenre класса QueryExecutor.
        /// </summary>
        [TestMethod]
        public void UpdateGenre_GenreIdAndName_TrueReturned()
        {
            QueryExecutor.GetInstance().AddGenre("TestGenre2020");

            bool expected = true;
            bool actual = QueryExecutor.GetInstance().UpdateGenre(QueryExecutor.GetInstance().GetGenreId("TestGenre2020"), "TestGenre2020_1");

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тестирует метод UpdateGenre класса QueryExecutor.
        /// </summary>
        [TestMethod]
        public void UpdateGenre_GenreIdAndName_FalseReturned()
        {
            QueryExecutor.GetInstance().AddGenre("TestGenre2020");

            bool expected = false;
            bool actual = QueryExecutor.GetInstance().UpdateGenre(QueryExecutor.GetInstance().GetGenreId("TestGenre2020"), "TestGenre2020");

            Assert.AreEqual(expected, actual);
        }
    }
}

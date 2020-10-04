using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicalPerformers.Model.Configurations;

namespace MusicalPerformers.Model.Tests.Configurations
{
    /// <summary>
    /// Тестирование класса ConfigurationDatabaseTests.
    /// </summary>
    [TestClass]
    public class ConfigurationDatabaseTests
    {
        /// <summary>
        /// Конфигурация базы данных.
        /// </summary>
        private ConfigurationDatabase _configDb;

        /// <summary>
        /// Инициализация теста.
        /// </summary>
        [TestInitialize]
        public void Initialize()
        {
            _configDb = new ConfigurationDatabase();
        }

        /// <summary>
        /// Тестирует правильность сгенерированная строки подключения.
        /// </summary>
        [TestMethod]
        public void ConnectionString_CorrectValue()
        {
            string expected = $@"Data Source=.\SQLEXPRESS;Initial Catalog=MusicalPerformers;Integrated Security=True";
            string actual = _configDb.ConnectionString;

            Assert.AreEqual(expected, actual);
        }
    }
}

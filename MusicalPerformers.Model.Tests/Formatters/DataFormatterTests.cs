using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicalPerformers.Model.Configurations;
using MusicalPerformers.Model.Database.Interactions;
using MusicalPerformers.Model.Formatters;
using System;
using System.Data;

namespace MusicalPerformers.Model.Tests.Formatters
{
    /// <summary>
    /// Тестирование класса DataFormatterTests.
    /// </summary>
    [TestClass]
    public class DataFormatterTests
    {
        #region Свойства
        /// <summary>
        /// Источник данных.
        /// </summary>
        private DataTable _source;
        #endregion

        /// <summary>
        /// Инициализация теста.
        /// </summary>
        [TestInitialize]
        public void Initialize()
        {
            _source = QueryExecutor.GetInstance(new ConfigurationDatabase()).GetRoles();
        }

        /// <summary>
        /// Тестирует метод GetValue класса DataFormatter.
        /// </summary>
        [TestMethod]
        public void GetValue_SourceAndColumnName_DataReturned()
        {
            Assert.IsNotNull(DataFormatter.GetValue<string>(_source, "name"));
        }

        /// <summary>
        /// Тестирует метод GetValue класса DataFormatter.
        /// </summary>
        [TestMethod]
        public void GetValue_SourceAndColumnName_ExceptionReturned()
        {
            try
            {
                DataFormatter.GetValue<string>(_source, "");
            }
            catch(Exception ex)
            {
                Assert.IsNotNull(ex);
            }
        }
    }
}

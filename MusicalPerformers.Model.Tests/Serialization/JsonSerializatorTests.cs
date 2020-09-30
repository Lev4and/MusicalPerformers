using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicalPerformers.Model.Configurations;
using MusicalPerformers.Model.Serialization;
using System.IO;

namespace MusicalPerformers.Model.Tests.Serialization
{
    /// <summary>
    /// Тестирование класса JsonSerializator.
    /// </summary>
    [TestClass]
    public class JsonSerializatorTests
    {
        /// <summary>
        /// 
        /// </summary>
        private string _fileSavePath;
        /// <summary>
        /// 
        /// </summary>
        private ConfigurationDatabase _configDb;

        /// <summary>
        /// 
        /// </summary>
        [TestInitialize]
        public void Initialize()
        {
            _fileSavePath = "For Tests/ConfigurationDatabase.json";
            _configDb = new ConfigurationDatabase();
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void Save_ConfigDbAndFileSavePath_CreatedFile()
        {
            JsonSerializator.GetInstance().Save(_configDb, _fileSavePath);

            bool expected = true;
            bool actual = File.Exists(_fileSavePath);

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void Load_FileSavePath_ConfigurationDatabaseObject()
        {
            var obj = JsonSerializator.GetInstance().Load<ConfigurationDatabase>(_fileSavePath);

            bool expected = true;
            bool actual = obj is ConfigurationDatabase;

            Assert.AreEqual(expected, actual);
        }
    }
}

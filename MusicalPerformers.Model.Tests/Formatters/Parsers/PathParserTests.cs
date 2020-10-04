using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicalPerformers.Model.Formatters.Parsers;

namespace MusicalPerformers.Model.Tests.Formatters.Parsers
{
    /// <summary>
    /// Тестирование класса PathParser.
    /// </summary>
    [TestClass]
    public class PathParserTests
    {
        #region Свойства
        /// <summary>
        /// Путь к файлу.
        /// </summary>
        private string _path;
        /// <summary>
        /// Расширение файла.
        /// </summary>
        private string _expansion;
        #endregion

        /// <summary>
        /// Инициализация теста.
        /// </summary>
        [TestInitialize]
        public void Initialize()
        {
            _path = @"C:\Users\User\Desktop\Test.txt";
            _expansion = ".txt";
        }

        /// <summary>
        /// Тестирует метод IsCorrectExtension класса PathParser.
        /// </summary>
        [TestMethod]
        public void IsCorrectExtension_PathAndExpansion_TrueReturned()
        {
            bool expected = true;
            bool actual = PathParser.IsCorrectExtension(_path, _expansion);

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тестирует метод IsCorrectExtension класса PathParser.
        /// </summary>
        [TestMethod]
        public void IsCorrectExtension_PathAndExpansion_FalseReturned()
        {
            bool expected = false;
            bool actual = PathParser.IsCorrectExtension(_path, ".bin");

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тестирует метод IsCorrectExtension класса PathParser.
        /// </summary>
        [TestMethod]
        public void IsCorrectExtension_PathAndExpansions_TrueReturned()
        {
            string[] expansions = new string[] { $"{_expansion}", ".exe" };

            bool expected = true;
            bool actual = PathParser.IsCorrectExtension(_path, expansions);

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тестирует метод IsCorrectExtension класса PathParser.
        /// </summary>
        [TestMethod]
        public void IsCorrectExtension_PathAndExpansions_FalseReturned()
        {
            string[] expansions = new string[] { ".doc", ".exe" };

            bool expected = false;
            bool actual = PathParser.IsCorrectExtension(_path, expansions);

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тестирует метод GetFileName класса PathParser.
        /// </summary>
        [TestMethod]
        public void GetFileName_Path_FileNameReturned()
        {
            string expected = "Test";
            string actual = PathParser.GetFileName(_path);

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тестирует метод GetFileName класса PathParser.
        /// </summary>
        [TestMethod]
        public void GetFileExtension_Path_FileExtensionReturned()
        {
            string expected = ".txt";
            string actual = PathParser.GetFileExtension(_path);

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тестирует метод GetFileNameWithExtension класса PathParser.
        /// </summary>
        [TestMethod]
        public void GetFileNameWithExtension_Path_FileNameWithExtensionReturned()
        {
            string expected = "Test.txt";
            string actual = PathParser.GetFileNameWithExtension(_path);

            Assert.AreEqual(expected, actual);
        }
    }
}

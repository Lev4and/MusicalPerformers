using System;
using System.Windows.Forms;

namespace MusicalPerformers.WinForms.Views.Forms
{
    /// <summary>
    /// Представляет окно или диалоговое окно, которое составляет пользовательский интерфейс приложения.
    /// </summary>
    public partial class Main : Form
    {
        #region Свойства
        /// <summary>
        /// Экземпляр объекта класса Main.
        /// </summary>
        private static Main _instance;
        /// <summary>
        /// Инкапсулирует метод, который принимает два параметра и не возвращает значения, позволяющий скрыть форму.
        /// </summary>
        private EventHandler _hideForm;
        #endregion

        /// <summary>
        /// Получение экземпляр объекта класса Main.
        /// </summary>
        /// <returns>Экземпляр объекта класса Main.</returns>
        public static Main GetInstance()
        {
            if(_instance == null)
            {
                _instance = new Main();
            }

            return _instance;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса Main.
        /// </summary>
        private Main()
        {
            InitializeComponent();

            _hideForm = (s, e) => { this.Visible = false; };

            Authorization.Click += _hideForm;
            Registration.Click += _hideForm;
            Settings.Click += _hideForm;
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку Authorization.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные произошедшего события.</param>
        private void Authorization_Click(object sender, EventArgs e)
        {
            new Authorization().Show();
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку Registration.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные произошедшего события.</param>
        private void Registration_Click(object sender, EventArgs e)
        {
            new Registration().Show();
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку Settings.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные произошедшего события.</param>
        private void Settings_Click(object sender, EventArgs e)
        {
            new Settings().Show();
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку Exit.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные произошедшего события.</param>
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

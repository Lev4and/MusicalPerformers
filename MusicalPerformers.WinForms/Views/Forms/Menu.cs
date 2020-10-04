using System;
using System.Windows.Forms;

namespace MusicalPerformers.WinForms.Views.Forms
{
    /// <summary>
    /// Представляет окно или диалоговое окно, которое составляет пользовательский интерфейс приложения.
    /// </summary>
    public partial class Menu : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса Menu.
        /// </summary>
        public Menu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку Genres.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные произошедшего события.</param>
        private void Genres_Click(object sender, EventArgs e)
        {
            new Genres().Show();

            this.Close();
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

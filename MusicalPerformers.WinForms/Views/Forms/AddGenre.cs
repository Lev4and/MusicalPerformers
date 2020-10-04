using MusicalPerformers.Model.Database.Interactions;
using System;
using System.Windows.Forms;

namespace MusicalPerformers.WinForms.Views.Forms
{
    /// <summary>
    /// Представляет окно или диалоговое окно, которое составляет пользовательский интерфейс приложения.
    /// </summary>
    public partial class AddGenre : Form
    {
        #region Свойства
        /// <summary>
        /// Название жанра.
        /// </summary>
        private string _genreName;

        /// <summary>
        /// Событие, происходящее при изменении каких-либо данных.
        /// </summary>
        public event Action OnSourceDataChanged;
        #endregion

        /// <summary>
        /// Инициализирует новый экземпляр класса AddGenre.
        /// </summary>
        public AddGenre()
        {
            InitializeComponent();

            _genreName = "";

            SetDataForControls();
            SetEventHandlerForControls();
        }

        /// <summary>
        /// Присвоение данных для элементов управления.
        /// </summary>
        private void SetDataForControls()
        {
            GenreName.Text = _genreName;
        }

        /// <summary>
        /// Присвоение обработчиков событий для элементов управления.
        /// </summary>
        private void SetEventHandlerForControls()
        {
            GenreName.TextChanged += (s, e) =>
            {
                _genreName = GenreName.Text;
            };
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку Save.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные произошедшего события.</param>
        private void Save_Click(object sender, EventArgs e)
        {
            if(_genreName.Length > 0)
            {
                if(QueryExecutor.GetInstance().AddGenre(_genreName))
                {
                    MessageBox.Show("Успешное добавление", "Уведомление");

                    OnSourceDataChanged?.Invoke();
                }
                else
                {
                    MessageBox.Show("Жанр с такими данными уже существует", "Ошибка");
                }
            }
            else
            {
                MessageBox.Show("Вы ввели не все данные", "Ошибка");
            }
        }
    }
}

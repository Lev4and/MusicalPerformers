using MusicalPerformers.Model.Database.Interactions;
using System;
using System.Windows.Forms;

namespace MusicalPerformers.WinForms.Views.Forms
{
    /// <summary>
    /// Представляет окно или диалоговое окно, которое составляет пользовательский интерфейс приложения.
    /// </summary>
    public partial class Genres : Form
    {
        #region Свойства
        /// <summary>
        /// Название жанра.
        /// </summary>
        private string _genreName;
        #endregion

        /// <summary>
        /// Инициализирует новый экземпляр класса Genres.
        /// </summary>
        public Genres()
        {
            InitializeComponent();

            _genreName = "";

            SetEventHandlerForControls();
        }

        /// <summary>
        /// Присвоение обработчиков событий для элементов управления.
        /// </summary>
        private void SetEventHandlerForControls()
        {
            SearchQuery.TextChanged += (s, e) =>
            {
                _genreName = SearchQuery.Text;
            };

            DataGridView.SelectionChanged += (s, e) =>
            {
                if(DataGridView.SelectedRows.Count > 0)
                {
                    SetVisibilityPropertyForControls(GetSelectedValue("GenreIdTextBoxColumn") != null);
                }
                else
                {
                    SetVisibilityPropertyForControls(false);
                }
            };
        }

        /// <summary>
        /// Присвоение источников данных для элементов управления.
        /// </summary>
        private void SetDataSourceForControls()
        {
            DataGridView.DataSource = QueryExecutor.GetInstance().GetGenres(_genreName);
        }

        /// <summary>
        /// Присвоение видимости для элементов управления.
        /// </summary>
        /// <param name="value">Значение видимости.</param>
        private void SetVisibilityPropertyForControls(bool value)
        {
            Edit.Visible = value;
            Remove.Visible = value;
        }

        /// <summary>
        /// Получение определенного значения из указанного столбца выделенной строки.
        /// </summary>
        /// <param name="columnName">Название столбца.</param>
        /// <returns>Значение.</returns>
        private object GetSelectedValue(string columnName)
        {
            return DataGridView.SelectedRows[0].Cells[columnName].Value;
        }

        /// <summary>
        /// Обработчик события загрузки формы.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные произошедшего события.</param>
        private void Genres_Load(object sender, EventArgs e)
        {
            SetDataSourceForControls();
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку Add.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные произошедшего события.</param>
        private void Add_Click(object sender, EventArgs e)
        {
            var form = new AddGenre();

            form.OnSourceDataChanged += () => SetDataSourceForControls();
            form.Show();
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку Edit.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные произошедшего события.</param>
        private void Edit_Click(object sender, EventArgs e)
        {
            var form = new EditGenre(Convert.ToInt32(GetSelectedValue("GenreIdTextBoxColumn")));

            form.OnSourceDataChanged += () => SetDataSourceForControls();
            form.Show();
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку Remove.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные произошедшего события.</param>
        private void Remove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить эту запись?", "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                QueryExecutor.GetInstance().RemoveGenre(Convert.ToInt32(GetSelectedValue("GenreIdTextBoxColumn")));

                MessageBox.Show("Успешное удаление", "Уведомление");

                SetDataSourceForControls();
            }
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку Search.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные произошедшего события.</param>
        private void Search_Click(object sender, EventArgs e)
        {
            SetDataSourceForControls();
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку Back.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные произошедшего события.</param>
        private void Back_Click(object sender, EventArgs e)
        {
            new Menu().Show();

            this.Close();
        }
    }
}

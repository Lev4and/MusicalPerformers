using MusicalPerformers.Model.Configurations;
using System;
using System.Windows.Forms;

namespace MusicalPerformers.WinForms.Views.Forms
{
    /// <summary>
    /// Представляет окно или диалоговое окно, которое составляет пользовательский интерфейс приложения.
    /// </summary>
    public partial class Settings : Form
    {
        /// <summary>
        /// Адрес сервера базы данных.
        /// </summary>
        private string _serverAddress;
        /// <summary>
        /// Название базы данных.
        /// </summary>
        private string _databaseName;
        /// <summary>
        /// Конфигурация базы данных.
        /// </summary>
        private ConfigurationDatabase _configDb;

        /// <summary>
        /// Инициализирует новый экземпляр класса Settings.
        /// </summary>
        public Settings()
        {
            InitializeComponent();

            _configDb = ConfigurationDatabase.GetConfiguration();

            _serverAddress = _configDb.ServerAddress;
            _databaseName = _configDb.DatabaseName;

            SetDataForControls();
            SetToolTipForControls();
            SetEventHandlerForControls();
        }

        /// <summary>
        /// Заполнение элементов управления данными.
        /// </summary>
        private void SetDataForControls()
        {
            ServerAddress.Text = _serverAddress;
            DatabaseName.Text = _databaseName;
        }

        /// <summary>
        /// Присвоение всплывающих подсказок для элементов управления.
        /// </summary>
        private void SetToolTipForControls()
        {
            InfoToolTip.SetToolTip(ServerAddress, _serverAddress);
            InfoToolTip.SetToolTip(DatabaseName, _databaseName);
        }

        /// <summary>
        /// Присвоение обработчиков событий для элементов управления.
        /// </summary>
        private void SetEventHandlerForControls()
        {
            ServerAddress.TextChanged += (s, e) =>
            {
                _serverAddress = ServerAddress.Text;

                InfoToolTip.SetToolTip(ServerAddress, ServerAddress.Text);
            };

            DatabaseName.TextChanged += (s, e) =>
            {
                _databaseName = DatabaseName.Text;

                InfoToolTip.SetToolTip(DatabaseName, DatabaseName.Text);
            };
        }

        /// <summary>
        /// Перезаписывание и сохранение конфигурации базы данных.
        /// </summary>
        private void RewriteAndSaveConfigurationDatabase()
        {
            _configDb.ServerAddress = _serverAddress;
            _configDb.DatabaseName = _databaseName;

            _configDb.Save();
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку Back.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные произошедшего события.</param>
        private void Back_Click(object sender, EventArgs e)
        {
            Main.GetInstance().Visible = true;

            this.Close();
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку Save.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные произошедшего события.</param>
        private void Save_Click(object sender, EventArgs e)
        {
            if(_serverAddress.Length > 0 && _databaseName.Length > 0)
            {
                RewriteAndSaveConfigurationDatabase();

                MessageBox.Show("Успешное сохранение", "Уведомление");

                Application.Restart();
            }
            else
            {
                MessageBox.Show("Вы ввели не все данные", "Ошибка");
            }
        }
    }
}

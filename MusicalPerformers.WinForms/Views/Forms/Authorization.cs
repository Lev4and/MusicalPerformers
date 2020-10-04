using MusicalPerformers.Model.Configurations;
using MusicalPerformers.Model.Database.Interactions;
using MusicalPerformers.Model.Formatters;
using System;
using System.Data;
using System.Windows.Forms;

namespace MusicalPerformers.WinForms.Views.Forms
{
    /// <summary>
    /// Представляет окно или диалоговое окно, которое составляет пользовательский интерфейс приложения.
    /// </summary>
    public partial class Authorization : Form
    {
        /// <summary>
        /// Логин.
        /// </summary>
        private string _login;
        /// <summary>
        /// Пароль.
        /// </summary>
        private string _password;

        /// <summary>
        /// Инициализирует новый экземпляр класса Authorization.
        /// </summary>
        public Authorization()
        {
            InitializeComponent();

            _login = "";
            _password = "";

            SetDataForControls();
            SetEventHandlerForControls();
        }

        /// <summary>
        /// Заполнение элементов управления данными.
        /// </summary>
        private void SetDataForControls()
        {
            Login.Text = _login;
            Password.Text = _password;
        }

        /// <summary>
        /// Присвоение обработчиков событий для элементов управления.
        /// </summary>
        private void SetEventHandlerForControls()
        {
            Login.TextChanged += (s, e) => 
            { 
                _login = Login.Text;

                InfoToolTip.SetToolTip(Login, Login.Text);
            };

            Password.TextChanged += (s, e) =>
            { 
                _password = Password.Text;
            };
        }

        /// <summary>
        /// Перезаписывание и сохранение пользовательской конфигурации.
        /// </summary>
        private void RewriteAndSaveConfigurationUser()
        {
            var userInformation = QueryExecutor.GetInstance().GetUserInformation(_login);

            var userId = DataFormatter.GetValue<int>(userInformation, "user_id");
            var roleName = DataFormatter.GetValue<string>(userInformation, "role_name");

            var configUser = new ConfigurationUser(userId, roleName);
            configUser.Save();
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
        /// Обработчик события нажатия на кнопку Next.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные произошедшего события.</param>
        private void Next_Click(object sender, EventArgs e)
        {
            try
            {
                if(QueryExecutor.GetInstance(ConfigurationDatabase.GetConfiguration()).UserAuthorization(_login, _password))
                {
                    RewriteAndSaveConfigurationUser();

                    MessageBox.Show("Успех", "Уведомление");
                }
                else
                {
                    MessageBox.Show("Вы ввели неверные данные", "Ошибка");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
    }
}

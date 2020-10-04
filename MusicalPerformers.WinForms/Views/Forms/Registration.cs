using MusicalPerformers.Model.Database.Interactions;
using System;
using System.Windows.Forms;

namespace MusicalPerformers.WinForms.Views.Forms
{
    /// <summary>
    /// Представляет окно или диалоговое окно, которое составляет пользовательский интерфейс приложения.
    /// </summary>
    public partial class Registration : Form
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
        /// Подтвержденный пароль.
        /// </summary>
        private string _repatPassword;

        /// <summary>
        /// Инициализирует новый экземпляр класса Registration.
        /// </summary>
        public Registration()
        {
            InitializeComponent();

            _login = "";
            _password = "";
            _repatPassword = "";

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
            RepeatPassword.Text = _repatPassword;
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

            RepeatPassword.TextChanged += (s, e) =>
            {
                _repatPassword = RepeatPassword.Text;
            };
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
                if(_password == _repatPassword)
                {
                    if (QueryExecutor.GetInstance().AddUser(QueryExecutor.GetInstance().GetRoleId("Пользователь"), _login, _password, null))
                    {
                        MessageBox.Show("Успех", "Уведомление");

                        new Authorization().Show();

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Пользователь с таким логином уже существует", "Ошибка");
                    }
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают", "Ошибка");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
    }
}

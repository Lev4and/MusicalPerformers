using System;
using System.Windows.Forms;

namespace MusicalPerformers.WinForms.Views.Forms
{
    public partial class Main : Form
    {
        private static Main _instance;

        public static Main GetInstance()
        {
            if(_instance == null)
            {
                _instance = new Main();
            }

            return _instance;
        }

        private Main()
        {
            InitializeComponent();

            Authorization.Click += (s, e) => { this.Visible = false; };
            Registration.Click += (s, e) => { this.Visible = false; };
            Settings.Click += (s, e) => { this.Visible = false; };
        }

        private void Authorization_Click(object sender, EventArgs e)
        {
            new Authorization().Show();
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            new Registration().Show();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            new Settings().Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

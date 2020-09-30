using System;
using System.Windows.Forms;

namespace MusicalPerformers.WinForms
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(MusicalPerformers.WinForms.Views.Forms.Main.GetInstance());
        }
    }
}

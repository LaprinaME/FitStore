using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;  // Для работы с иконкой

namespace FitStore
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Устанавливаем иконку приложения
            ApplicationIcon = new Icon(@"C:\Users\Outsider\source\repos\FitStore\FitStore\icon.ico"); // Укажите путь к вашему файлу иконки

            // Запуск главной формы
            Application.Run(new Form1());
        }

        // Это свойство установит иконку для приложения
        public static Icon ApplicationIcon { get; set; }
    }
}

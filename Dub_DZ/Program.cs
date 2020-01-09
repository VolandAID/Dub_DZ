using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dub_DZ
{
    static class Program
    {
        //    Домашнее задание
        // Разработать программу, реализующую многопоточный поиск в файле.
        // Программа должна быть разработана в виде приложения Windows Forms на языке C#. По желанию вместо Windows Forms возможно использование WPF;
        // В качестве основы используется макет, разработанный в лабораторных работах №4 и №5;
        // Реализуйте функцию поиска с использованием расстояния Левенштейна в многопоточном варианте.Количество потоков для запуска функции поиска вводится на форме в поле ввода (TextBox).
        // Реализуйте функцию записи результатов поиска в файл отчета. Файл отчета создается в формате.txt или .html
        // Пример реализации ДЗ рассмотрен в учебном пособии, глава «Пример многопоточного поиска в текстовом файле с использованием технологии Windows Forms».

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.WriteLine("Домашняя работа");
            Console.Title = "Дубянский А. И., ИУ5Ц-51Б";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}


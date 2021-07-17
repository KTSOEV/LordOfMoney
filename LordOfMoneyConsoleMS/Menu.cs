using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LordOfMoneyConsole
{
    class Menu
    {
        string line;//Переменная, в которую будут записываться данные
        public Menu()
        {

        }

        public void ShowMenu()
        {
            StreamReader sr = new StreamReader("config.ini");//Открытие ридера
            line = sr.ReadLine();//Запись данных с файла в переменную line
            while (line != null)//Цикл который проверяет, если переменная не пуста, тогда отображается последний введённый баланс
            {
                Console.WriteLine("Последний введённый вами баланс: " + line);
                line = sr.ReadLine();
            }
            sr.Close();//Закрытие ридера

            Console.WriteLine("1. Ввести остаток баланс на текущий месяц/Input salary balance");
            Console.WriteLine("2. ");
            Console.WriteLine("3. О программе/About");
            Console.WriteLine("4. Выход/Exit");
        }
    }    
}

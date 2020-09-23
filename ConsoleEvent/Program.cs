using System;
using System.IO;
using static System.Console;
using Logging;

namespace ConsoleEvent
{
    class Program
    {
        static void Main()
        {
            const string loginSource = "user";
            const string passwordSource = "123";

            Write("Введите логин: ");
            string login = ReadLine();            
            
            Write("Введите пароль: ");
            string password = ReadLine();

            CheckAccount.Info += LogToConsole.InfoShow;
            CheckAccount.Info += LogToFile.InfoLog;

            CheckAccount.Success += LogToConsole.SuccessShow;
            CheckAccount.Success += LogToFile.SuccessLog;

            CheckAccount.Error += LogToConsole.ErrorShow;
            CheckAccount.Error += LogToFile.ErrorLog;

            bool check = CheckAccount.Check(login, password);

            if (check)
            {
                WriteLine("Вход разрешён");
            }
            else
            {
                WriteLine("Вход запрещён");
            }
        }


    }
}

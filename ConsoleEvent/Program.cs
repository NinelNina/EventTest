using System;
using System.IO;
using static System.Console;

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

            CheckAccount.Info += InfoShow;
            CheckAccount.Info += InfoLog;

            CheckAccount.Success += SuccessShow;
            CheckAccount.Success += SuccessLog;

            CheckAccount.Error += ErrorShow;
            CheckAccount.Error += ErrorLog;

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
        static void InfoShow(string message)
        {
            WriteLine($"[INFO] {message}");
        }

        static void ErrorShow(string message)
        {
            WriteLine($"[ERROR] {message}");
        }
        static void SuccessShow(string message)
        {
            WriteLine($"[SUCCESS] {message}");
        }
        
        static void InfoLog(string message)
        {
            using (StreamWriter file = new StreamWriter("event_test.log"))
            {
                file.WriteLine($"[INFO] {message}");
            }
        }
        static void SuccessLog(string message)
        {
            using (StreamWriter file = new StreamWriter("event_test.log"))
            {
                file.WriteLine($"[SUCCESS] {message}");
            }
        }        
        static void ErrorLog(string message)
        {
            using (StreamWriter file = new StreamWriter("event_test.log"))
            {
                file.WriteLine($"[ERROR] {message}");
            }
        }

    }
}

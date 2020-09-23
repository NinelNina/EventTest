using System;
using static System.Console;

namespace ConsoleEvent
{
    class Program
    {
        static void Main()
        {
            string loginSource = "user";
            string passwordSource = "123";

            Write("Введите логин: ");
            string login = ReadLine();            
            
            Write("Введите пароль: ");
            string password = ReadLine();

            CheckAccount.Info += InfoShow;
            CheckAccount.Success += SuccessShow;
            CheckAccount.Error += ErrorShow;

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

    }
}

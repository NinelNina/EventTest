using System;
using static System.Console;

namespace ConsoleEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            string loginSource = "user";
            string passwordSource = "123";

            Write("Введите логин: ");
            string login = ReadLine();            
            
            Write("Введите пароль: ");
            string password = ReadLine();

            if (login == loginSource && password == passwordSource)
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

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEvent
{
    public delegate void Message(string message);
    public static class CheckAccount
    {
        private const string loginSourse = "user";
        private const string passwordSourse = "123";

        public static Message Error;
        public static Message Success;
        public static Message Info;

        public static bool Check(string login, string password)
        {
            bool flagLogin = false;
            bool flagPassword = false;

            if (login == loginSourse)
            {
                Info?.Invoke("Логин введён верно");
                flagLogin = true;
            }
            else
            {
                Error?.Invoke("Логин введён неверно");
            }            
            
            if (password == passwordSourse)
            {
                Info?.Invoke("Пароль введён верно");
                flagPassword = true;
            }
            else
            {
                Error?.Invoke("Пароль введён неверно");
            }

            if (flagLogin && flagPassword)
            {
                Success?.Invoke("Доступ разрешён");
                return true;
            }
            else
            {
                Error?.Invoke("Доступ запрещён");
                return false;
            }
        }

    }
}

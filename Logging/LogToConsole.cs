using System;
using static System.Console;

namespace Logging
{
    public static class LogToConsole
    {
        public static void InfoShow(string message)
        {
            WriteLine($"[INFO] {message}");
        }

        public static void ErrorShow(string message)
        {
            WriteLine($"[ERROR] {message}");
        }
        public static void SuccessShow(string message)
        {
            WriteLine($"[SUCCESS] {message}");
        }
    }
}

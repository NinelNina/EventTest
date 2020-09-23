using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Logging
{
    public static class LogToFile
    {
        private static void Log(string message)
        {
            using (StreamWriter file = new StreamWriter("event_test.log"))
            {
                file.WriteLine(message);
            }
        }

        public static void InfoLog(string message)
        {
            Log($"[INFO] {message}");
            
        }
        public static void SuccessLog(string message)
        {
            Log($"[SUCCESS] {message}");
            
        }
        public static void ErrorLog(string message)
        {
            Log($"[ERROR] {message}");
        }
    }
}

using System;
using System.IO;

namespace Agent6.Logging
{
    public static class Logger
    {
        private static readonly object _lock = new object();

        public static void LogError(string message)
        {
            lock (_lock)
            {
                var logMessage = $"[{DateTime.UtcNow:yyyy-MM-dd HH:mm:ss UTC}] ERROR: {message}";
                Console.WriteLine(logMessage);
                try
                {
                    File.AppendAllText("error.log", logMessage + Environment.NewLine);
                }
                catch
                {
                    // Silently ignore logging failures to prevent cascading errors
                }
            }
        }

        public static void LogInfo(string message)
        {
            lock (_lock)
            {
                var logMessage = $"[{DateTime.UtcNow:yyyy-MM-dd HH:mm:ss UTC}] INFO: {message}";
                Console.WriteLine(logMessage);
                try
                {
                    File.AppendAllText("app.log", logMessage + Environment.NewLine);
                }
                catch
                {
                    // Silently ignore logging failures to prevent cascading errors
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace FileLoggerApp
{
    internal class Logger
    {
        private readonly string _logFile;

        public Logger(string filePath)
        {
            this._logFile = filePath;
        }

        public void Log(string message, LogLevel level)
        {
            string logMessage = FormatMessage(message,level);
            
            try
            {
                File.AppendAllText(_logFile, logMessage);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Log yazılırken hata oluştu: " + ex.Message);
            }
        }

        public void LogFolder(string message, LogLevel level)
        {
            string logMessage = FormatMessage(message, level);

            string logFolder = "Log";

            if (!Directory.Exists(logFolder))
            {
                Directory.CreateDirectory(logFolder);
            }

            string logPath = Path.Combine(logFolder, _logFile);

            try
            {
                File.AppendAllText(logPath, logMessage);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Log yazılırken hata oluştu: " + ex.Message);
            }
        }


        public string FormatMessage(string message, LogLevel logLevel)
        {
            string formatMessage = $"[{DateTime.Now}][{logLevel.ToString().ToUpper()}]" + $"{message} \n";
            return formatMessage;
        }

    }
}

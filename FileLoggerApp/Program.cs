namespace FileLoggerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger("log.txt");
            logger.Log("------------------- Application Started -------------------", LogLevel.Info);
            logger.Log("User login attempt", LogLevel.Info);
            logger.Log("Low memory warning", LogLevel.Warning);
            logger.Log("Database connection failed", LogLevel.Error);

            Console.WriteLine("Log written");


            Logger logger2 = new Logger("systemLog.txt");
            logger2.LogFolder("------------------- Application Started -------------------", LogLevel.Info);
            logger2.LogFolder("User login attempt", LogLevel.Info);
            logger2.LogFolder("Low memory warning", LogLevel.Warning);
            logger2.LogFolder("Database connection failed", LogLevel.Error);

            Console.WriteLine("Log written to path");

        }
    }
}
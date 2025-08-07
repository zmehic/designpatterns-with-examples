namespace DesignPatterns.Singleton
{
    public class Logger
    {
        private static Logger logger;

        private Logger() {}

        public static Logger GetInstance()
        {
            logger ??= new Logger();
            return logger;
        }

        public void Log(string message)
        {
            Console.WriteLine($"Logged: {message}");
        }
    }
}

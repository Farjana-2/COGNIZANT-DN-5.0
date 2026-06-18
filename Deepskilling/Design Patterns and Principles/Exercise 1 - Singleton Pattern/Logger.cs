namespace DesignPatternsAndPrinciples
{
    // SINGLETON PATTERN - Only ONE Logger can ever exist!
    internal class Logger
    {
        private static Logger _instance;
        private Logger()
        {
            Console.WriteLine("Logger created for the first time!");
        }

        public static Logger GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Logger();
            }
            return _instance;
        }
        public void Log(string message)
        {
            Console.WriteLine($"[{DateTime.Now}] LOG: {message}");
        }
    }
}
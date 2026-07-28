namespace DesignPatternsAndPrinciples
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Logger logger1 = Logger.GetInstance();
            Logger logger2 = Logger.GetInstance();

            logger1.Log("Application started!");
            logger1.Log("User logged in!");

            logger2.Log("Data saved successfully!");

            if (logger1 == logger2)
                Console.WriteLine("logger1 and logger2 are the SAME object!");
            else
                Console.WriteLine("They are different objects!");

            Console.ReadKey();
        }
    }
}

using System;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseLogger logger = new ConsoleLogger();
            logger.Log("App started");
            Console.ReadKey();
        }
    }
}

using System;

namespace CounterExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = new Counter();
            counter.Increment();
            counter.Increment();
            Console.WriteLine(counter.Increment());

            Console.WriteLine("App started.");
            Console.ReadKey();
        }
    }
}

using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            TestBuilderPattern testBuilderPattern = new TestBuilderPattern();

            testBuilderPattern.Test();

            Console.ReadKey();
        }
    }
}

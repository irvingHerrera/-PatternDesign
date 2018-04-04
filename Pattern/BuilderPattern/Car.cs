using System;

namespace BuilderPattern
{
    public class Car
    {
        private int doors = 0;

        public void AddParts()
        {
            this.doors = 4;
        }

        public void DoSomething()
        {
            Console.WriteLine($"Tengo {doors} puertas");
        }
    }
}

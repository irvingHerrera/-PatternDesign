using System;

namespace AbstractFactory
{
    public class Lion : ICarnivore
    {
        /// <summary>
        /// The 'ProductB1' class
        /// </summary>
        public void Eat(IHerbivore h)
        {
            // Eat Wildebeest
            Console.WriteLine(this.GetType().Name +
              " eats " + h.GetType().Name);
        }
    }
}

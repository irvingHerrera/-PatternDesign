using System;

namespace AbstractFactory
{
    /// <summary>
    /// The 'ProductB2' class
    /// </summary>
    public class Wolf : ICarnivore
    {
        public void Eat(IHerbivore h)
        {
            Console.WriteLine(this.GetType().Name +
            " eats " + h.GetType().Name);
        }
    }
}

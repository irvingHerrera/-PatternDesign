using System;

namespace AbstractFactory
{
    /// <summary>
    /// The 'ConcreteFactory2' class
    /// </summary>
    public class AmericaFactory : IContinentFactory
    {
        public ICarnivore CreateCarnivore()
        {
            return new Wolf();
        }

        public IHerbivore CreateHerbivore()
        {
            return new Bison();
        }
    }
}

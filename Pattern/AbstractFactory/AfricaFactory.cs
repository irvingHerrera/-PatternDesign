namespace AbstractFactory
{
    /// <summary>
    /// The 'ConcreteFactory1' class
    /// </summary>
    public class AfricaFactory : IContinentFactory
    {
        public ICarnivore CreateCarnivore()
        {
            return new Lion();
        }

        public IHerbivore CreateHerbivore()
        {
            return new Wildebeest();
        }
    }
}

namespace AbstractFactory
{
    /// <summary>
    /// The 'Client' class 
    /// </summary>
    public class AnimalWorld
    {
        private IHerbivore herbivore;
        private ICarnivore carnivore;

        public AnimalWorld(IContinentFactory factory)
        {
            carnivore = factory.CreateCarnivore();
            herbivore = factory.CreateHerbivore();
        }

        public void RunFoodChain()
        {
            carnivore.Eat(herbivore);
        }
    }
}

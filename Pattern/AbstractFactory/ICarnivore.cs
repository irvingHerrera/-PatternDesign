namespace AbstractFactory
{
    /// <summary>
    /// The 'AbstractProductB' abstract class
    /// </summary>
    public interface ICarnivore
    {
        void Eat(IHerbivore h);
    }
}

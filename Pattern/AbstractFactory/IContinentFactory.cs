namespace AbstractFactory
{
    /// <summary>
    /// The 'AbstractFactory' abstract class --- Interfaz
    /// </summary>
    public interface IContinentFactory
    {
        IHerbivore CreateHerbivore();
        ICarnivore CreateCarnivore();
    }
}

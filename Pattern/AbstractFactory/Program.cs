using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Animales concretos de africa");
            IContinentFactory africa = new AfricaFactory();
            AnimalWorld clienteAfrica = new AnimalWorld(africa);
            clienteAfrica.RunFoodChain();

            Console.WriteLine("Animales concretos de america");
            IContinentFactory america = new AmericaFactory();
            AnimalWorld clienteAmerica = new AnimalWorld(america);
            clienteAmerica.RunFoodChain();

            Console.ReadKey();

        }
    }
}

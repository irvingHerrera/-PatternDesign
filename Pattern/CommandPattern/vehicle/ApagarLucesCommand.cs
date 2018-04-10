using System;

namespace CommandPattern.vehicle
{
    public class ApagarLucesCommand : ICommand
    {
        private LucesReceiver luces;

        public ApagarLucesCommand(LucesReceiver luces)
        {
            this.luces = luces;
        }

        public void Execute()
        {
            luces.Apagar();
            Console.WriteLine("Apagando las luces");
        }
    }
}

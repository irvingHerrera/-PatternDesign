using System;

namespace CommandPattern.vehicle
{
    public class EncenderLucesCommand : ICommand
    {
        // Referencia al objeto cuyo método se quiere encapsular
        private LucesReceiver luces;

        // El constructor inyectará el objeto cuyo método se quiere encapsular
        public EncenderLucesCommand(LucesReceiver luces)
        {
            this.luces = luces;
        }

        // El método Execute() ejecutará el método encapsulado
        public void Execute()
        {
            int distancia = luces.Encender();
            Console.WriteLine(string.Format("Encendiendo luces. Alumbrando a una distancia de {0} metros.", distancia));
        }
    }
}

using ObserverPattern.Inventario;
using ObserverPattern.Sensor;
using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos un medidor de sensores
            ISubject sensores = new MedidorSensores(20, 380, 200);

            // Creamos dos observers: un display y un emisor de alertas.
            // Se realiza la suscripcion a traves del constructor
            IObserver display = new ObserverDisplay(sensores);
            IObserver alerta = new ObserverAlerta(sensores);

            // Modificamos valores del subject. Los observers son automaticamente informados
            // y actuaran automaticamente
            ((MedidorSensores)sensores).NivelAceite += 10;
            ((MedidorSensores)sensores).NivelAceite += 10;
            ((MedidorSensores)sensores).NivelAgua += 100;
            ((MedidorSensores)sensores).NivelPresionNeumaticos -= 50;
            ((MedidorSensores)sensores).NivelAceite += 10;
            ((MedidorSensores)sensores).NivelAgua += 100;
            ((MedidorSensores)sensores).NivelAgua += 100;

            Console.WriteLine("\n Inventario \n");

            // Create IBM stock and attach investors

            IBM ibm = new IBM("IBM", 120.00);
            ibm.Attach(new Investor("Sorros"));
            ibm.Attach(new Investor("Berkshire"));

            // Fluctuating prices will notify investors

            ibm.Price = 120.10;
            ibm.Price = 121.00;
            ibm.Price = 120.50;
            ibm.Price = 120.75;

            Console.ReadKey();

        }
    }
}

using DecoratorPattern.library;
using DecoratorPattern.vehicle;
using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vehiculo \n");

            Vehiculo monovolumen = new Monovolumen();
            Vehiculo berlina = new Berlina();

            monovolumen = new Gasolina(monovolumen);

            MostrarCaracteristicas(monovolumen);
            MostrarCaracteristicas(berlina);


            Console.WriteLine("\n Libreria");

            // Create book

            Book book = new Book("Worley", "Inside ASP.NET", 10);
            book.Display();

            // Create video

            Video video = new Video("Spielberg", "Jaws", 23, 92);
            video.Display();

            // Make video borrowable, then borrow and display

            Console.WriteLine("\nMaking video borrowable:");

            Borrowable borrowvideo = new Borrowable(video);
            borrowvideo.BorrowItem("Customer #1");
            borrowvideo.BorrowItem("Customer #2");

            borrowvideo.Display();

            Console.ReadKey();
        }

        private static void MostrarCaracteristicas(Vehiculo v)
        {
            Console.WriteLine(string.Format("{0}\n\t- Velocidad punta de {1} km/h \n\tConsumo medio de {2} l/100km\n",
                                            v.Descripcion(),
                                            v.VelocidadMaxima(),
                                            v.Consumo()));
        }
    }
}

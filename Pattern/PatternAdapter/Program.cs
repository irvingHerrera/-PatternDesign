using System;

namespace PatternAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciamos el enchufe español, que es el que existe en nuestro país
            IEnchufeEuropeo enchufeEuropeo = new EnchufeEspanol();

            // Instanciamos el adaptador pasándole el enchufe español como parámetro
            IEnchufeIngles adaptador = new AdapterInglesEuropeo(enchufeEuropeo);

            // Creamos el taladro pasándole nuestro adaptador
            Taladro taladro = new Taladro(adaptador);

            // Encendemos el taladro
            taladro.Encender();

            Console.ReadKey();
        }
    }
}

using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factory Method");
            //Se crea una clase que se encarga de crear las instancias
            // y un metodo que tiene la responsabilidad de crear las instancias
            MotorFactory motorFactoryMethod = new MotorFactory();
            var diselMethod = motorFactoryMethod.CreateInstance(TypeMotor.Disel);
            Console.WriteLine(diselMethod.InyectarCombustible(20));
            var gasolinaMethod = motorFactoryMethod.CreateInstance(TypeMotor.Gasolina);
            Console.WriteLine(gasolinaMethod.InyectarCombustible(10));
            Console.ReadKey();

            Console.WriteLine("Abstract Method");
            //Esta parte se crean clases concretas definiendo una clase 
            //factoria para la creacion de una clase concreta
            //Se define el tipo de factoria
            IMotorFactory motorFactory = ObtenerMotor(TypeMotor.Gasolina);

            //Se obtiene la instancia concreta
            IMotor gasolina = motorFactory.CreateInstance();
            //Resultado
            Console.WriteLine(gasolina.InyectarCombustible(50));

            //Se define el tipo de factoria y obtiene la instancia concreta
            IMotor disel = ObtenerMotor(TypeMotor.Disel).CreateInstance();

            //Resultado
            Console.WriteLine(disel.InyectarCombustible(540));

            Console.ReadKey();
        }

        static IMotorFactory ObtenerMotor(TypeMotor type)
        {

            switch (type)
            {
                case TypeMotor.Gasolina:
                    return new MotorGasolinaFactory();
                case TypeMotor.Disel:
                    return new MotorDieselFactory();
                default: return null;
            }
        }
    }
}

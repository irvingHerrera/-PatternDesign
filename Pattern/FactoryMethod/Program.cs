using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Forma 1 simple factory");
            MotorFactory motorFactoryMethod = new MotorFactory();
            var diselMethod = motorFactoryMethod.CreateInstance(TypeMotor.Disel);
            Console.WriteLine(diselMethod.InyectarCombustible(20));
            var gasolinaMethod = motorFactoryMethod.CreateInstance(TypeMotor.Gasolina);
            Console.WriteLine(gasolinaMethod.InyectarCombustible(10));
            Console.ReadKey();

            Console.WriteLine("Forma 2 Factory Method");
            IMotorFactory motorFactory = ObtenerMotor(TypeMotor.Gasolina);

            IMotor gasolina = motorFactory.CreateInstance();
            Console.WriteLine(gasolina.InyectarCombustible(50));

            IMotor disel = ObtenerMotor(TypeMotor.Disel).CreateInstance();
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

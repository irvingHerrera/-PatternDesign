using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
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

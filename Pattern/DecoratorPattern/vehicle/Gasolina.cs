using System;

namespace DecoratorPattern.vehicle
{
    public class Gasolina : Decorator
    {
        public Gasolina(Vehiculo vehiculo) 
            : base(vehiculo)
        {
        }

        public override double Consumo()
        {
            return vehiculo.Consumo() + 1.2;
        }

        public override string Descripcion()
        {
            return vehiculo.Descripcion() + " Gasolina";
        }

        public override int VelocidadMaxima()
        {
            return vehiculo.VelocidadMaxima() + 60;
        }
    }
}

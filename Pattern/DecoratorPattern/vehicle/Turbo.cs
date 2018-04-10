using System;

namespace DecoratorPattern.vehicle
{
    public class Turbo : Decorator
    {
        protected Turbo(Vehiculo vehiculo) : base(vehiculo)
        {
        }

        public override double Consumo()
        {
            return vehiculo.VelocidadMaxima() + 30;
        }

        public override string Descripcion()
        {
            return vehiculo.Descripcion() + " Turbo";
        }

        public override int VelocidadMaxima()
        {
            return vehiculo.VelocidadMaxima() + 30;
        }
    }
}

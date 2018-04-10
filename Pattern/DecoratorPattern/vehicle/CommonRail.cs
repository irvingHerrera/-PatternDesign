using System;

namespace DecoratorPattern.vehicle
{
    public class CommonRail : Decorator
    {
        protected CommonRail(Vehiculo vehiculo) : base(vehiculo)
        {
        }

        public override double Consumo()
        {
            return vehiculo.Consumo() - 0.4;
        }

        public override string Descripcion()
        {
            return vehiculo.Descripcion() + " Common Rail";
        }

        public override int VelocidadMaxima()
        {
            return vehiculo.VelocidadMaxima() - 15;
        }
    }
}

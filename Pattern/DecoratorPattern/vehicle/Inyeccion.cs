using System;

namespace DecoratorPattern.vehicle
{
    public class Inyeccion : Decorator
    {
        protected Inyeccion(Vehiculo vehiculo) : base(vehiculo)
        {
        }

        public override double Consumo()
        {
            return vehiculo.Consumo() - 1.2;
        }

        public override string Descripcion()
        {
            return vehiculo.Descripcion() + " Inyección";
        }

        public override int VelocidadMaxima()
        {
            return vehiculo.VelocidadMaxima();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.vehicle
{
    public class Diesel : Decorator
    {
        protected Diesel(Vehiculo vehiculo) : base(vehiculo)
        {
        }

        public override double Consumo()
        {
            return vehiculo.Consumo() - 0.8;
        }

        public override string Descripcion()
        {
            return vehiculo.Descripcion() + " Diesel";
        }

        public override int VelocidadMaxima()
        {
            return vehiculo.VelocidadMaxima() + 20;
        }
    }
}

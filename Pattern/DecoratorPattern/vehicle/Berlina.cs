using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.vehicle
{
    public class Berlina : Vehiculo
    {
        public Berlina()
        {
            descripcion = "Berlina";
        }

        public override double Consumo()
        {
            return 6.2;
        }

        public override int VelocidadMaxima()
        {
            return 180;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.vehicle
{
    public abstract class Decorator : Vehiculo
    {
        // Declaramos el método como abstracto para que todos los decoradores lo
        // reimplementen.
        public override abstract string Descripcion();

        protected Vehiculo vehiculo;

        protected Decorator(Vehiculo vehiculo)
        {
            this.vehiculo = vehiculo;
        }

    }
}

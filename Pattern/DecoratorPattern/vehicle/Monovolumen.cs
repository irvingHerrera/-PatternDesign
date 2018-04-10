using System;

namespace DecoratorPattern.vehicle
{
    public class Monovolumen : Vehiculo
    {
        public Monovolumen()
        {
            descripcion = "Monovolumen";
        }
        
        public override double Consumo()
        {
            return 7.5;
        }

        public override int VelocidadMaxima()
        {
            return 160;
        }
    }
}

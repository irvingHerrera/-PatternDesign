using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class MotorDieselFactory : IMotorFactory
    {
        public IMotor CreateInstance()
        {
            IMotor motorDiesel = new MotorDiesel()
            {
                Estabilidad = 60,
                ParMotor = 90,
                Potencia = 700,
                Rendimiento = 220,
                VelocidadNominal = 80
            };

            return motorDiesel;
        }
    }
}

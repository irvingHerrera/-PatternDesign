using System;

namespace FactoryMethod
{
    public class MotorGasolina : IMotor
    {
        public int Estabilidad { get; set; }
        public decimal ParMotor { get; set; }
        public int Potencia { get; set; }
        public decimal Rendimiento { get; set; }
        public int VelocidadNominal { get; set; }

        public string ConsumirCombustible()
        {
            return RealizarExplosion();
        }

        public string InyectarCombustible(int cantidad)
        {
            return string.Format("MotorGasolina: Inyectados {0} ml. de Gasolina.", cantidad);
        }

        public string RealizarEscape()
        {
            return "MotorGasolina: Realizado escape de gases";
        }

        public string RealizarExpansion()
        {
            return "MotorGasolina: Realizada expansion";
        }

        private string RealizarExplosion()
        {
            return "MotorGasolina: Realizada explosion de la Gasolina";
        }
    }
}

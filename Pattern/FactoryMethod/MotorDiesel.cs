namespace FactoryMethod
{
    public class MotorDiesel : IMotor
    {
        public int Estabilidad { get; set; }
        public decimal ParMotor { get; set; }
        public int Potencia { get; set; }
        public decimal Rendimiento { get; set; }
        public int VelocidadNominal { get; set; }

        public string ConsumirCombustible()
        {
            return RealizarCombustion();
        }

        public string InyectarCombustible(int cantidad)
        {
            return string.Format("MotorDiesel: Inyectados {0} ml. de Disel.", cantidad);
        }

        public string RealizarEscape()
        {
            return "MotorDiesel: Realizado escape de gases";
        }

        public string RealizarExpansion()
        {
            return "MotorDiesel: Realizada expansion";
        }

        private string RealizarCombustion()
        {
            return "MotorDiesel: Realizada combustion del Gasoil";
        }
    }
}

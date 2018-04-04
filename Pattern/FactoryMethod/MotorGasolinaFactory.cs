namespace FactoryMethod
{
    public class MotorGasolinaFactory : IMotorFactory
    {
        public IMotor CreateInstance()
        {
            var motorGasolina = new MotorGasolina()
            {
                Estabilidad = 100,
                ParMotor = 40,
                Potencia = 1200,
                Rendimiento = 420,
                VelocidadNominal = 47
            };

            return motorGasolina;
        }
    }
}

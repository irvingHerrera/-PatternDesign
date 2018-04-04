namespace FactoryMethod
{
    /// <summary>
    /// Esta clase se encarga de crear todas las intancias de las clases
    /// </summary>
    public class MotorFactory
    {
        public IMotor CreateInstance(TypeMotor tipoMotor)
        {
            IMotor resultado;

            switch (tipoMotor)
            {
                case TypeMotor.Disel:
                    resultado = new MotorDiesel();
                    break;
                case TypeMotor.Gasolina:
                    resultado = new MotorGasolina();
                    break;
                default:
                    resultado = null;
                    break;
            }

            return resultado;
        }
    }
}

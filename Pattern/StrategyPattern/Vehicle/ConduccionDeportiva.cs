namespace StrategyPattern.Vehicle
{
    public class ConduccionDeportiva : ITipoConduccion
    {
        public string ObtenerDescripcion()
        {
            return "Conduccion Deportiva";
        }

        public int ObtenerIncrementoVelocidad(float decilitrosCombustible)
        {
            return (int)(decilitrosCombustible * 0.618) + 3;
        }

        public int ObtenerPotencia(float decilitrosCombustible)
        {
            return (int)(decilitrosCombustible * 0.987) + 5;
        }
    }
}

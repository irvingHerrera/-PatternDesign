namespace FactoryMethod
{
    public interface IMotor
    {
        string ConsumirCombustible();
        string InyectarCombustible(int cantidad);
        string RealizarEscape();
        string RealizarExpansion();
    }
}

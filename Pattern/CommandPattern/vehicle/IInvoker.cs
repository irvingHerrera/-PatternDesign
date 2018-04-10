namespace CommandPattern.vehicle
{
    public interface IInvoker
    {
        // Inyecta un ICommand, permitiendo cambiar la operación encapsulada en
        // tiempo de ejecución
        void SetCommand(ICommand command);

        // Ejecuta el método encapsulado
        void Invoke();
    }
}

namespace DecoratorPattern.vehicle
{
    public abstract class Vehiculo
    {
        // Atributo común a todos los objetos que heredarán de esta clase
        protected string descripcion = "Vehículo genérico";

        // Método no abstracto que devolverá el contenido de la descripción
        // Se declara como virtual para que pueda sustituirse en las clases derivadas
        public virtual string Descripcion()
        {
            return descripcion;
        }

        // Métodos abstractos
        public abstract int VelocidadMaxima();
        public abstract double Consumo();
    }
}

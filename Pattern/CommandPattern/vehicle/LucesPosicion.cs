namespace CommandPattern.vehicle
{
    public class LucesPosicion : LucesReceiver
    {
        private const int DISTANCIA = 1;

        public override int Encender()
        {
            this.encendidas = true;
            return DISTANCIA;
        }
    }
}

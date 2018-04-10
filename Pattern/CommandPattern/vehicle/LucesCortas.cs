using System;

namespace CommandPattern.vehicle
{
    public class LucesCortas : LucesReceiver
    {
        private const int DISTANCIA = 40;

        public override int Encender()
        {
            encendidas = true;
            return DISTANCIA;
        }
    }
}

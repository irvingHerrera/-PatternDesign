using Facade.sppedChange.Contract;
using System;

namespace Facade.sppedChange
{
    public class PalancaCambios : IPalancaCambios
    {
        private int _velocidadActual;

        public int GetVelocidadActual()
        {
            return _velocidadActual;
        }

        public void InsertarVelocidad(int velocidad)
        {
            Console.WriteLine("Introduciendo marcha " + velocidad);
            this._velocidadActual = velocidad;
        }

        public void PuntoMuerto()
        {
            Console.WriteLine("Sacando velocidad " + this._velocidadActual);
            this._velocidadActual = 0;
        }
    }
}

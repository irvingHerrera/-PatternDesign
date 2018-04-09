using Facade.sppedChange.Contract;
using System;

namespace Facade.sppedChange
{
    public class Acelerador : IAcelerador
    {
        public void PresionarAcelerador()
        {
            Console.WriteLine("Acelerador presionado");
        }

        public void SoltarAcelerador()
        {
            Console.WriteLine("Acelerador levantado");
        }
    }
}

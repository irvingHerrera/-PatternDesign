using Facade.sppedChange.Contract;
using System;

namespace Facade.sppedChange
{
    public class Embrague : IEmbrague
    {
        public void PresionarEmbrague()
        {
            Console.WriteLine("Embrague presionado");
        }

        public void SoltarEmbrague()
        {
            Console.WriteLine("Embrague suelto");
        }
    }
}

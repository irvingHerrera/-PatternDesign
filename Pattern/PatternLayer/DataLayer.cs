using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLayer
{
    public class DataLayer
    {
        public PresentationLayer SetLowerLayer()
        {
            return new PresentationLayer();
        }

        public void S1(string parametro)
        {
            Console.WriteLine("Entramos al servicio s1 {0}", parametro);
        }
    }
}

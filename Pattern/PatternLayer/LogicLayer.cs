using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLayer
{
    public class LogicLayer
    {
        public LogicLayer()
        {

        }

        public DataLayer SetLowerLayer()
        {
            return new DataLayer();
        }


        public void S2(string parametro)
        {
            Console.WriteLine("Entramos al servicio {0}", nameof(LogicLayer));
            SetLowerLayer().S1(parametro);
            Console.WriteLine("Terminamos servicio {0}", nameof(LogicLayer));
        }
    }
}

using System;

namespace PatternLayer
{
    public class PresentationLayer
    {
        public PresentationLayer()
        {

        }

        public LogicLayer SetLowerLayer()
        {
            return new LogicLayer();
        }

        public void S3(string parametro)
        {
            Console.WriteLine("Entramos al servicio {0}", nameof(PresentationLayer));
            SetLowerLayer().S2(parametro);
            Console.WriteLine("Terminamos servicio {0}", nameof(PresentationLayer));
        }
    }
}

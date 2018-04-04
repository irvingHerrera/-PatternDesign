using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            PresentationLayer presentation = new PresentationLayer();
            presentation.S3("capa presentacion");
            Console.ReadKey();
        }
    }
}

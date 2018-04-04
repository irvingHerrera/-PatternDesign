using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Director
    {
        public Car Construct()
        {
            CardBuilder builder = new CardBuilder();

            builder.Step1();
            builder.Step2();
            return builder.GetResult();
        }
    }
}

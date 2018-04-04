using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class TestBuilderPattern
    {
        public void Test()
        {
            var shop = new Director();
            var carBuilder = new CardBuilder();
            var car = shop.Construct();

            car.DoSomething();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PatternSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Patron singleton");
            Console.WriteLine(Singleton.Instance.Name);
            Console.WriteLine(Singleton.Instance.Date);
            Console.WriteLine("Pausa...");
            Thread.Sleep(100000);
            Console.WriteLine(Singleton.Instance.Name);
            Console.WriteLine(Singleton.Instance.Date);

            Console.ReadKey();

        }
    }
}

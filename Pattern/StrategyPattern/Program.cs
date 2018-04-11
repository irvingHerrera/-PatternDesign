using StrategyPattern.Ordenamiento;
using StrategyPattern.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Vehiculo \n");

            Vehiculo v = new Vehiculo();
            v.ConduccionDeportiva();
            v.Acelerar(2.4f);

            Console.WriteLine("");

            v.ConduccionNormal();
            v.Acelerar(2.4f);

            

            Console.WriteLine("\n Ordenamiento \n");

            SortedList studentRecords = new SortedList();

            studentRecords.Add("Samual");
            studentRecords.Add("Jimmy");
            studentRecords.Add("Sandra");
            studentRecords.Add("Vivek");
            studentRecords.Add("Anna");

            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();

            Console.ReadLine();
        }
    }
}

using Facade.Credit;
using Facade.sppedChange;
using Facade.sppedChange.Contract;
using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            IAcelerador acelerador = new Acelerador();
            IEmbrague embrague = new Embrague();
            IPalancaCambios palancaCambios = new PalancaCambios();

            Centralita centralita = new Centralita(embrague, acelerador, palancaCambios);
            centralita.AumentarMarcha();


            Console.WriteLine("\n ----- ------ -------");
            // Facade
            Mortgage mortgage = new Mortgage();

            // Evaluate mortgage eligibility for customer
            Customer customer = new Customer("Ann McKinsey");
            bool eligible = mortgage.IsEligible(customer, 125000);

            Console.WriteLine("\n" + customer.Name +
                " has been " + (eligible ? "Approved" : "Rejected"));


            Console.ReadKey();
        }
    }
}

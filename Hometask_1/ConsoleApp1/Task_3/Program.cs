using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Address address = new Address();
            address.Index = "02225";
            address.City = "Kyiv";
            address.Country = "Ukraine";
            address.Street = "Perova";
            address.House = "10";
            address.Apartment = "335";

            address.Show();
            Console.ReadKey();

        }
    }
}

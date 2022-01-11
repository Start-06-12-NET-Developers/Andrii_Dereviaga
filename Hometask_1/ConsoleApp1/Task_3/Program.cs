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
            address.index = "02225";
            address.city = "Kyiv";
            address.country = "Ukraine";
            address.street = "Perova";
            address.house = "10";
            address.apartment = "335";

            address.Show();
            Console.ReadKey();

        }
    }
}

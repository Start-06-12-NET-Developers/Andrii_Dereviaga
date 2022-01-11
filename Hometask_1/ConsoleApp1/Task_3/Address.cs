using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Address
    {
        string index; public string Index { get; set; }
        string country; public string Country { get; set; }
        string city; public string City { get; set; }
        string street; public string Street { get; set; }
        string house; public string House { get; set; }
        string apartment; public string Apartment { get; set; }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Index - {Index}\nCountry - {Country}\nCity - {City}\nStreet - {Street}\nHouse - {House}\nApartment - {Apartment}");
        
        }

        
    }
}

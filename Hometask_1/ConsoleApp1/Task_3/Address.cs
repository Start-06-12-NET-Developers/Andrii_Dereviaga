using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Address
    {
        public string index; public string Index { get { return index; } set { index = value; } }
        public string country; public string Country { get { return country; } set { country = value; } }
        public string city; public string City { get { return city; } set { city = value; } }
        public string street; public string Street { get { return street; } set { street = value; } }
        public string house; public string House { get { return house; } set { house = value; } }
        public string apartment; public string Apartment { get { return apartment; } set { apartment = value; } }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Index - {Index}\nCountry - {Country}\nCity - {City}\nStreet - {Street}\nHouse - {House}\nApartment - {Apartment}");
        
        }

        
    }
}

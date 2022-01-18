using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Ship : Vehicle
    {
        string port = "Odessa";
        int passangerNumber = 300;

        public Ship (double price, int speed, int date) : base(price, speed, date)
        {

        }

        public override void PrintInfo()
        {

            Console.WriteLine("Passanger number is - {0}", passangerNumber);
            Console.WriteLine("Port is - {0}", port);
            Console.WriteLine("Price - {0}", price);
            Console.WriteLine("Speed - {0}", speed);
            Console.WriteLine("Date - {0}", date);
            Console.WriteLine("\n\n\n");
        }
    }
}

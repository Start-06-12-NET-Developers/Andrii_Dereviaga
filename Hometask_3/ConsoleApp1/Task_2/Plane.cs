using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Plane : Vehicle
    {
        int height = 500;
        int passangerNumber = 150;

        public Plane(double price, int speed, int date) : base(price, speed, date)
        {

        }

        public override void PrintInfo()
        {

            Console.WriteLine("Passanger number is", passangerNumber);      
            Console.WriteLine("Height is {0}", height);
            Console.WriteLine("Price - {0}", price);
            Console.WriteLine("Speed - {0}", speed);
            Console.WriteLine("Date - {0}", date);
            Console.WriteLine("\n\n\n");
        }
    }
}

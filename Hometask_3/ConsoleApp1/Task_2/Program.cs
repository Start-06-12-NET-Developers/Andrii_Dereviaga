using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane(500000, 900, 1984);
            plane.PrintInfo();

            Ship ship = new Ship(30000, 50, 2000);
            ship.PrintInfo();

            Car car = new Car(5000, 150, 2015);
            car.PrintInfo();

            Console.ReadKey();
        }
    }
}

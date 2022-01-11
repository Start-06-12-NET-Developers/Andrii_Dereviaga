using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point("Point_A", 0, 0);
            Point point2 = new Point("Point_B", 50, 0);
            Point point3 = new Point("Point_C", 50, 50);

            Figure figure = new Figure(point1, point2, point3);
            figure.PerimeterCalculator(point1, point2, point3);

            Console.ReadKey();

        }
    }
}

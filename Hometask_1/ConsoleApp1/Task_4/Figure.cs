using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Figure
    {
        public Figure(Point point1, Point point2, Point point3)
        {
            Console.WriteLine("Triangle");
                        
        }

        public double LengthSide(Point A, Point B)
        {
            double lengthAB = Math.Sqrt(Math.Pow((B.X - A.X), 2) + Math.Pow((B.Y - A.Y), 2));
            return lengthAB;
        }

        public void PerimeterCalculator(Point point1, Point point2, Point point3)
        {
            double perimeter = LengthSide(point1, point2) + LengthSide(point3, point1) + LengthSide(point2, point3);
            Console.WriteLine("Perimeter is {0} ", perimeter);
        }
    }
}

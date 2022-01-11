using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Figure
    {
        public Figure(Point[] array)
        {
            if (array.Length == 3)
            {
                Console.WriteLine("Треугольник");
            }
            if (array.Length == 4)
            {
                Console.WriteLine("Четырехугольник");
            }
            if (array.Length == 5)
            {
                Console.WriteLine("пятиугольник");
            }

        }

        public double LengthSide(Point A, Point B)
        {
            double lengthAB = Math.Sqrt(Math.Pow((B.X - A.X), 2) + Math.Pow((B.Y - A.Y), 2));
            return lengthAB;
        }

        //public void PerimeterCalculator(Point point1, Point point2, Point point3)
        //{
        //    double perimeter = LengthSide(point1, point2) + LengthSide(point3, point1) + LengthSide(point2, point3);
        //    Console.WriteLine("Perimeter is {0} ", perimeter);
        //}


        public void PerimeterCalculator(Point[] array)
        {
            double perimeter = default;

            for (int i = 0; i < 1; i++)
            {
                 perimeter = LengthSide(array[i], array[i + 1]) + LengthSide(array[i + 2], array[i]) + 
                 LengthSide(array[i + 1], array[i + 2]);
            }
            Console.WriteLine("Perimeter is {0} ", perimeter);
        }
    }
}

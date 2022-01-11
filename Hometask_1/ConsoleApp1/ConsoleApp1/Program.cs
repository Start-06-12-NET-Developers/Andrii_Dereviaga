using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace ConsoleApp1
{

    public class Rectangle
    {
        private double side1, side2, area, perimeter;
          
                
        public Rectangle(double side1, double side2)

        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double AreaCalculator(double side1, double side2)
        { 
            area = this.side1 * this.side2;   
            return area;    
        
        }

        public double PerimeterCalculator(double side1, double side2)

        { 
        
            perimeter = (this.side1 + this.side2)*2;   
            return Perimeter;   
        
        }

        public double Area
        {
           
            get { return area; }
        }

        public double Perimeter
        {
            get { return perimeter; }
        }

    }




    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter side 1 value");
            double side1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter side 2 value");
            double side2 = double.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle(side1, side2);
            rectangle.AreaCalculator(side1, side2); 
            rectangle.PerimeterCalculator(side1, side2);
                      

            Console.WriteLine($"Rectangle area is {rectangle.Area}");
            Console.WriteLine($"Rectangle perimeter is {rectangle.Perimeter}");
            Console.ReadKey();

        }
    }
}

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
            Console.WriteLine("Enter some text");

            Printer printer = new Printer();
            string text = Console.ReadLine();
            printer.Print(text);

            Printer printer1 = new Green();
            printer1.Print(text);

            Printer printer2 = new Red();
            printer2.Print(text);

            Yellow printer3 = new Yellow();
            printer3.Print(text);

            //Printer instanceUp = printer3;
            //instanceUp.Print(text);

            //Yellow instanceDown = (Yellow)instanceUp;
            //instanceDown.Print(text);



            Console.ReadKey();
        }
    }
}

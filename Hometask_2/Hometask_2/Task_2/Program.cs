using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter surname");
            string surname = Console.ReadLine();

            Console.WriteLine("Enter name");
            string name = Console.ReadLine();

            Employee employee = new Employee(surname, name);

            Console.WriteLine("Enter position");
            string position = Console.ReadLine();

            Console.WriteLine("Enter work experience");
            string workExperience = Console.ReadLine();

        }
    }
}

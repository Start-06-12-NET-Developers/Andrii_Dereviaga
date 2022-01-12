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

            Console.WriteLine("Enter position: director, engineer, other");
            string position = Console.ReadLine();

            Console.WriteLine("Enter work experience, years");
            int workExperience = int.Parse(Console.ReadLine());

            double salary = employee.SalaryCalculator(workExperience, position);

            Console.WriteLine($"Employee - {employee.Name} {employee.Surname} Position - {position}");
            Console.WriteLine($"Salary - {salary}, Tax - {salary * 0.2}");

            Console.ReadKey();
            
        }
    }
}

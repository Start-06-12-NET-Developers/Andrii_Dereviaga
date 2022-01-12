using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Start:

            Console.Clear();

            Console.WriteLine("\nEnter Correct login");
            string login = Console.ReadLine();

            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Surname");
            string surname = Console.ReadLine();

            Console.WriteLine("Enter Age");
            int age = int.Parse(Console.ReadLine());

            User user = new User(login, name, surname, age);
            Console.WriteLine($"Date:Time - {user.Date} \nName - {user.Name} \n Surname - {user.Surname} \nAge - {user.Age}");
            Console.WriteLine("For continue enter y");
            
            if (Console.ReadKey().Key == ConsoleKey.Y) goto Start;
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            new Invoice();

            Console.WriteLine("Enter account");
            Invoice.account = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter customer");
            Invoice.customer = Console.ReadLine();

            Console.WriteLine("Enter provider");
            Invoice.provider = Console.ReadLine();

        Start:

            Console.WriteLine("\nEnter article: apples or chocolates");
            string article = Console.ReadLine();

            Console.WriteLine("Enter quantity");
            int quantity = int.Parse(Console.ReadLine());

            Invoice invoice = new Invoice();

            Console.WriteLine("Calculate with VAT? : F1 - yes, F2 - no");
            if (Console.ReadKey().Key == ConsoleKey.F1)
            {
                invoice.WithValueAddedTax(article, quantity);
            }
            else if (Console.ReadKey().Key == ConsoleKey.F2)
            {
                invoice.NoValueAddedTax(article, quantity);
            }
            else
            {
                Console.WriteLine("Wrong key. Execution terminated");
                Console.ReadKey();
                Environment.Exit(0);
            }

            Console.WriteLine("For continue enter y");

            if (Console.ReadKey().Key == ConsoleKey.Y) goto Start;

        }
    }
}

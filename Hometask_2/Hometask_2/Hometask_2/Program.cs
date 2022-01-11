using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Converter currency = new Converter(27.53, 31.30, 0.37);


            Console.WriteLine("Enter currency you want to change: usd, eur, rub, uah");
            string cur = Console.ReadLine();
            if (cur == "uah")
            { Console.WriteLine("What currency you want to buy? usd, eur, rub");
                string cur2 = Console.ReadLine();
                Console.WriteLine("How much UAH you want to spend? ");
                double quantity = double.Parse(Console.ReadLine());

                currency.Exchange(cur, cur2, quantity);

            }
            else
            {
                Console.WriteLine("Enter quantity");
                double quantity = double.Parse(Console.ReadLine());
                currency.Exchange(cur, quantity);
            }
        

            Console.ReadKey();
        }
    }
}

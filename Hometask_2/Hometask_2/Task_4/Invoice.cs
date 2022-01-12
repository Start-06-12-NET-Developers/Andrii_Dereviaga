using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Invoice
    {
        public static int account;
        public static string customer;
        public static string provider;

        
        public void WithValueAddedTax(string article, int quantity)
        {
            double price = 0;
            double summ;
            
            if (article == "apples") price = 25;
            else if (article == "chocolates") price = 30;
            else Console.WriteLine("No such article");

            summ = quantity * price + (quantity * price) * 0.2;

            Console.WriteLine($"\nAccount -  {account}\nCustomer - {customer}\nProvider - {provider}");
            Console.WriteLine($"Invoice price with VAT is {summ}");
        }

        public void NoValueAddedTax(string article, int quantity)
        {
            double price = 0;
            double summ;

            if (article == "apples") price = 25;
            else if (article == "chocolates") price = 30;
            else Console.WriteLine("No such article");

            summ = quantity * price;

            Console.WriteLine($" Account - {account}\n Customer - {customer}\n Provider - {provider}");
            Console.WriteLine($"Invoice price without VAT is {summ}");
        }

    }

}

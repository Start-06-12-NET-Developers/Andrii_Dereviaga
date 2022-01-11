using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_2
{
    public class Converter
    {
        double usd;
        public double USD { get { return usd; } }

        double eur;
        public double EUR { get { return EUR; } }

        double rub;
        public double RUB { get { return RUB; } }

        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
                    
        }

        public void Exchange(string cur, double quantity)
        {
            double cash = 0;

            if (cur == "usd") cash = usd * quantity;
            else if (cur == "eur") cash = eur * quantity;
            else if (cur == "rub") cash = rub * quantity;

            Console.WriteLine($"Overall is {cash} UAH");
        }

        public void Exchange(string cur, string cur2, double quantity)
        {
            double cash = 0;

            if (cur2 == "usd")
            {
                cash = quantity / usd;
                Console.WriteLine($"Overall is {cash} USD");
            }
            else if (cur2 == "eur")
            {
                cash = quantity / eur;
                Console.WriteLine($"Overall is {cash} EUR");
            }

            else if (cur2 == "rub")
            {
                cash = quantity / rub;
                Console.WriteLine($"Overall is {cash} UAH");
            }

        }

    }
}

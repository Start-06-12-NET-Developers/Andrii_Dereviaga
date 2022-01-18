using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Printer
    {
               
        public virtual void Print(string text)
        {

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(text);
            Console.WriteLine("\n");
                
        }
    }
}

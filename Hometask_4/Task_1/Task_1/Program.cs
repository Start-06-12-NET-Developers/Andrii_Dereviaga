using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter doc type: doc, txt, xml");
            string doctype = Console.ReadLine();
            if (doctype == "doc")
            {
                DOCHandler handler = new DOCHandler();
                handler.Create();
                handler.Open();
                handler.Change();
                handler.Save();
            }
            else if (doctype == "txt")
            {
                TXTHandler handler = new TXTHandler();
                handler.Create();
                handler.Open();
                handler.Change();
                handler.Save();
            }
            else if (doctype == "xml")
            { 
                XMLHandler handler = new XMLHandler();
                handler.Create();
                handler.Open();
                handler.Change();
                handler.Save();
            }

            Console.ReadKey();
            
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 4, 6, 8, 10, 14, 15 };

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0) Console.Write(array[i] + "  ");
            }
            Console.Write("\n");

            Console.WriteLine($"MaxValue - {array.Max()}, MinValue - {array.Min()}, Sum - {array.Sum()}, Average - {(array.Sum() / (double)array.Length)}");
            Console.ReadKey();
        }
    }
}

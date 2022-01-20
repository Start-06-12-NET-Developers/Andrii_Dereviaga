using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = 5;
            int columns = 10;
            MyMatrix myMatrix = new MyMatrix(lines, columns);
            
            int[] array1D = { 1, 3, 5, 6, 7, 8, 9 };
            int[,] array2D = myMatrix.BuildArray(myMatrix);
            int[,,] array3D = 
                { 
                { { 1, 2, 5, 7, 9 }, { 3, 4, 7, 3, 8 } }, 
                { { 5, 6, 6, 4 ,3 }, { 7, 8, 3, 9, 3 } }
                };

            Console.WriteLine();

            myMatrix.WriteArray(array1D);
            myMatrix.WriteArray(array2D);
            myMatrix.WriteArray(array3D);   

            Console.ReadLine();
        }
    }
}

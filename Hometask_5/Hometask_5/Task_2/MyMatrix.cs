using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class MyMatrix
    {
        internal int lines;
        internal int columns;
                

        Random random = new Random();

        public MyMatrix(int lines, int columns)
        { 
            this.lines = lines;
            this.columns = columns;
        }
     


        public int[,] BuildArray(MyMatrix myMatrix)
        {
            int[ , ] array = new int[myMatrix.lines, myMatrix.columns];

            Console.Write("Builded array\n\n");
            for (int i = 0; i < myMatrix.lines; i++)
            {
                for (int j = 0; j < myMatrix.columns; j++)
                {
                    array[i, j] = random.Next(0, 50);
                    Console.Write("{0}\t", array[i, j]);
                }
                Console.Write("\n");
            }
            return array;
        }


        public void WriteArray(int[] array)
        {
            Console.Write("\n1D array\n\n");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write("{0}\t", array[i]);
                
            }
            Console.Write("\n");
        }


        public void WriteArray(int[,] array)
        {
            Console.Write("\n2D array\n\n");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{0}\t", array[i, j]);
                }
                Console.Write("\n");
            }
        }

        public void WriteArray(int[,,] array)
        {
            Console.Write("\n3D array\n\n");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.Write("{0}\t", array[i, j, k]);
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
            }
        }

    }
}

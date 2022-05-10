//MinMax of 2d array

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.Mar31
{
    class Array_2D
    {
        static void Main(string[] args)
        {


            int[,] a2 = new int[3, 4];
            for (int r = 0; r < a2.GetLength(0); r++)
            {
                Console.WriteLine("Enter row elements of row " + r);
                for (int c = 0; c < a2.GetLength(1); c++)
                {
                    a2[r, c] = int.Parse(Console.ReadLine());
                }
            }
            for (int r = 0; r < a2.GetLength(0); r++)
            {
                for (int c = 0; c < a2.GetLength(1); c++)
                {
                    Console.Write(a2[r, c] + " ");
                }
                Console.WriteLine();
            }
            int max = int.MinValue; //////Minvalue will assign minimum no (-214748...)
            int min = int.MaxValue;
            for (int r = 0; r < a2.GetLength(0); r++)
            {
                for (int c = 0; c < a2.GetLength(1); c++)
                {

                    if (min > a2[r, c])
                        min = a2[r, c];
                    else if (a2[r, c] > max)
                        max = a2[r, c];
                    else
                        continue;
                }
            }
                Console.WriteLine("Min in Array " + min);
                Console.WriteLine("Max in Array " + max);
            
        }
    }
}
/*
         Enter row elements of row 0
        1
        2
        3
        4
        Enter row elements of row 1
        1
        2
        3
        4
        Enter row elements of row 2
        0
        1
        2
        3
        1 2 3 4
        1 2 3 4
        0 1 2 3
        Min in Array 0
        Max in Array 4
*/
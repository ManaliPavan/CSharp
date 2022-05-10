using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.Mar31
{
    class ColumnwiseMax
    {
        static void Main(string[] args)
        {


            int[,] arr2d = { { 1, 2, 3, 4 }, { -1, -2, -3, -4 }, { 4, 5, 6, 7 }, { 9, 0, 8, 7 } };
            int max = int.MinValue; //////Minvalue will assign minimum no (-214748...)



            for (int c = 0; c < arr2d.GetLength(1); c++)
            {
                max = int.MinValue;
                for (int r = 0; r < arr2d.GetLength(0); r++)
                {

                    if (arr2d[r, c] > max)
                        max = arr2d[r, c];
                    else
                        continue;
                }


                Console.WriteLine($"Max on column {c}  is {max}");
            }
        }
    }
}

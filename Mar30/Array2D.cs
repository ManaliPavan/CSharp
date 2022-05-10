using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.Mar30
{
    class Array2D
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
                    Console.Write(a2[r,c]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}

/*
 *      Enter row num
 *          5
 *                  
 *                  *
 *                 ***
 *                *****
 *               *******
 *              *********  */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.day4.Patterns
{
    class Pattern10
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter row num");
            int NumRow1 = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= NumRow1; i++)
            {
                for (int space = 1; space <= NumRow1 - i; space++)
                {

                    Console.Write(" ");

                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {

                    Console.Write("*");

                }
                Console.WriteLine();

            }
        }
    }
}

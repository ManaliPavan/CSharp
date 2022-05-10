/*
 *              *
 *             ***
 *            *****
 *           *******
 *          *********  */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.day4.Patterns
{
    class Pattern9
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 9; i = i + 2)
            {
                for (int space = 1; space <= (9 - i) / 2; space++)
                {

                    Console.Write(" ");

                }
                for (int j = 1; j <= i; j++)
                {

                    Console.Write("*");

                }
                Console.WriteLine();
            }
        }
    }
}

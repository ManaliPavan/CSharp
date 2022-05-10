/*
 *  1
 *  123
 *  12345
 *  1234567
 *  123456789   */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.day4.Patterns
{
    class Pattern7
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 9; i = i + 2)
            {

                for (int j = 1; j <= i; j++)
                {

                    Console.Write(j);

                }
                Console.WriteLine();
            }

        }
    }
}

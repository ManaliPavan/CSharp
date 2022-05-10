//    *
//    # #
//    * * *
//    # # # #
//    * * * * *
//    # # # # # #
//    * * * * * * *
//    # # # # # # # #
//    * * * * * * * * *
//    # # # # # # # # # #

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.day4.Patterns
{
    class Pattern3
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = i; j <= 10; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write("#");
                    }
                    else
                        Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}

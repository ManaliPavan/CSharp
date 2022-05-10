// *
// * *
// * * *
//  * * * *
//  * * * * *
//  * * * * * *
//  * * * * * * *
//  * * * * * * * *
//  * * * * * * * * *
//   * * * * * * * * * *

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.day4.Patterns
{
    class Pattern1
    {
        static void Main(string[] args)
        {


            for (int i = 1; i <= 10; i++)
            {
                for (int j = i; j <= 10; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

//                 1
//               2 1
//             3 2 1
//           4 3 2 1
//         5 4 3 2 1 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.day4.Patterns
{
    class Pattern6
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int space = 1; space <= 5 - i; space++)
                {

                    Console.Write(" ");

                }
                for (int j = 1; j <= i; j++)
                {

                    Console.Write(j);

                }
                Console.WriteLine();
            }

        }
    }
}

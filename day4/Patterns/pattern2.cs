
//   * * * * * * * * * *
//  * * * * * * * * *
//  * * * * * * * *
//  * * * * * * * 
//  * * * * * *
//  * * * * * 
//  * * * * 
//  * * * 
//  * * 
//  * 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.day4.Patterns
{
    class pattern2
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}

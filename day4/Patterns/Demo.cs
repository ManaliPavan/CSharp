//  * * * * * * * * * *
//  * * * * * * * * * *
//  * * * * * * * * * *
//  * * * * * * * * * *

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.day4.Patterns
{
    class Demo
    {
        static void Main(string[] args)
        {
            

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    } 
}


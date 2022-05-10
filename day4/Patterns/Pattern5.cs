
//      1
//      2 1
//      1 2 3
//      4 3 2 1
//      1 2 3 4 5


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.day4.Patterns
{
    class Pattern5
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                int k = 1;
                for (int j = i; j >= 1; j--)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(j);
                    }
                    else
                        Console.Write(k);
                    k++;
                }
                Console.WriteLine();
            }
            //or
            for (int i = 1; i <= 5; i++)
            {

                for (int j = i; j >= 1; j--)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(j);
                    }
                    else
                        Console.Write(i - j + 1);

                }
                Console.WriteLine();
            }


        }
    }
}

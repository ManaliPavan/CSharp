using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.Mar31
{
    class CommonIn2Array
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 5, 8, 0 };
            int[] b = { 1, 3, 4, 8, 9, 0, 2 };
            foreach (int d1 in a)
            {
                foreach (int d2 in b)
                {
                    if (d1 == d2)
                    {
                        Console.WriteLine(d1);
                    }
                }
            }
        }
    }
}

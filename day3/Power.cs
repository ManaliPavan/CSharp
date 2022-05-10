using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.day3
{
    class Power
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Base");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Power");
            int idx = Convert.ToInt32(Console.ReadLine());
            int res = 1;
            while(idx>0)
            {
                res = res * b;
                --idx;

            }
            Console.WriteLine(res);

        }
    }
}

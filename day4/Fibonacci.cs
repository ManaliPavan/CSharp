using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.day4
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int n = 10;
            int a = 0,b= 1;
            for(int i=1;i<=n;i++)
            {
                Console.Write(a+" ");
                int c = a + b;
                a = b;
                b = c;
            }
        }
    }

}

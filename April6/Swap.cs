using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.April6
{
    class Swap
    {

        static void swap(int x, int y)
        {
            int c = x;
            x = y;
            y = c;
        }
        static void Main(string[] args)
        {
            int a = 100, b = 200;
            Console.WriteLine($"before swap a={a} b={b}");
            swap(a, b);  /////call by value
            Console.WriteLine($"After swap a={a} b={b}");
        }

    }
    }
 

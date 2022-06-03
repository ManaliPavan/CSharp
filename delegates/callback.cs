using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.delegates
{ 
    public delegate void  mydel4(int a, int b);
    class callback
    {
        static void Multiply (int a, int b, mydel4 d)
        {
            Console.WriteLine($"Multiplication is {a*b}");
            d(45,45);
            }
        static void Add(int a,int b)
        {
            Console.WriteLine($"Addition : {a+b}");
        }
        static void Main(string[] args)
        {
            Multiply(10, 20, Add);

        }

       
    }
}

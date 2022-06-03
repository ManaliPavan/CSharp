using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.delegates
{
    class actionn
    {
        static void Main(string[] args)
        {
            Action<int,int> Addition=(a,b)=>
            {
                a = 34; b = 43;
                Console.WriteLine(a+b);
            };
            Func<int, float, float> Multiply = (a, b) =>
                {
                    a = 6;b = 2.3f;
                    return a * b;
                };
                float ans = Multiply(2, 2.3f);
                Console.WriteLine(ans);
            Predicate<int> Print = (a) =>
            {
                        if (a % 2 == 0)
                            return true;
                        else
                            return false;
            };
            bool b = Print(34);
            Console.WriteLine(b);
        }
    }
}

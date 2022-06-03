using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.delegates
{
    class predicate
    { 
      public static bool iseven(int a)
        {
            if (a % 2 == 0)
                return true;
            else
                return false;
        }
        public static bool isprime(int a)
        {
            int c = 0;
            for(int i=2;i<=a/2;i++)
            {
                if (a % i == 0)
                {
                    c++;
                }
            }
            if (c != 0)
            {
                return false;
            }
            else
                return true; 
        }
        static void Main(string[] args)
        {
            List<int> l = new List<int>()
            { 1,2,3,4,5,6,7,8,9,10 };
            List<int> ans1 = l.FindAll(n => n % 2 == 0);      //Lambda iseven list
            l.ForEach(element => Console.WriteLine(element));
            Predicate<int> p = iseven;
            //p += isprime;
            bool b=p(43);
            Console.WriteLine(b);
            Predicate<int> p1 = isprime;
            bool b1 = p1(32);
            Console.WriteLine(b1);
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.delegates
{
    public delegate void mydel(int m);
    public delegate int mydel1(int a, int b);
    class Class1
    {
        public int addition(int a,int b)
        {
            return a + b;
        }
        public int subtract(int a,int b)
        {
            return a - b;
        }

        public static void cube(int x)
        {
            Console.WriteLine(x*x*x);
        }
        public static void prime(int n)
        {
            int flag = 0;
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i != 0)
                    flag = 1;
                break;
            }
            if(flag==1)
            Console.WriteLine("prime");
             else
                Console.WriteLine("Not Prime");
        }
        public static void square(int n)
        {
            Console.WriteLine(n*n);
        }
        public static void factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial :" + fact);
        }
        
    }
    class class2
    {
        
        static void Main(string[] args)
        {
            long d = 1234_1234_1234;
            Console.WriteLine(d);
            mydel multi = Class1.factorial;
            multi += Class1.square;
            multi += Class1.prime;
            multi += Class1.cube;
            multi -= Class1.square;
            multi(5);
            /*mydel ob =Class1.factorial;
             ob(20);
            mydel ob1 = Class1.square;
            ob1(2);
            Class1 c = new Class1();
            mydel1 ob2 = c.addition;
            Console.WriteLine(ob2(5,8));
            */
        }
    }
}


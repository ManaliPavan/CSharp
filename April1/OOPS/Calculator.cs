using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.April1.OOPS
{
    class Calculator
    {
        public void Add(int a, int b, int c)
        {
            int sum = a + b + c;
            Console.WriteLine("Addition" + sum);
        }
        public int Factorial(int n)
        {
            int fact = 1;
            for (int i = 2; i <= n; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
        public bool isPrime(int n)
        {
            int flag = 0;
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    flag = 1;
                    break;
                }
            }
                if (flag == 1)
                {
                    return false;
                }
                else
                    return true;
            }
        
        public String Greet(String nm)
        {
            return "Good Afternoon" + nm;
        }
    }
    class Test
    {
        static void Main(string[] args)
        {

            Calculator c = new Calculator();
            c.Add(4,7,9);
            int f = c.Factorial(20);
            Console.WriteLine("factorial is"+f);
            bool b = c.isPrime(30);
            Console.WriteLine("Prime"+ b);
            String d = c.Greet("manali");
            Console.WriteLine(d);
        }
    }
}

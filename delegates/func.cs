using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.delegates
{
    public delegate void multiply();
    class func
    {
        public int Add(int a,int b)
        {
            return a + b;
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }
        static void Main(string[] args)
        {
            func fc = new func();
            Func<int, int, int> f1 = fc.Add;
            Func<int, int, int> f2 = fc.Subtract;
            int ans1=f1(4, 5);
            int ans2 = f2(6, 5);
            Console.WriteLine($"Addition : {ans1} Subtraction : {ans2}");


            multiply p = delegate () {                                     //anonymous method
                Console.WriteLine("Enter two numbers");
                double n1 = Convert.ToDouble(Console.ReadLine());
                int n2 = Convert.ToInt32(Console.ReadLine());
                double ans = n1 * n2;
                Console.WriteLine($"Multiplication {ans}");
            };
        }
    }
}

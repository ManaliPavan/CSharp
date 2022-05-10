using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.April4.Constructor
{
    class Calculator
    {
 /*       static void Add(int a,int b)
        { 
            Console.WriteLine("Sum"+(a+b)); 
        }
 */
        void Add(float a,float b)
        {
            Console.WriteLine("Sum" + (a + b));
        }
        void Add(int a, int b)
        {
            Console.WriteLine("Sum" + (a + b));
        }
        void Add(int a, int b,int c)
        {
            Console.WriteLine("Sum" + (a + b));
        }
        void Add(int a, float b)
        {
            Console.WriteLine("Sum" + (a + b));
        }
        void Add(float a, int b)
        {
            Console.WriteLine("Sum" + (a + b));
        }
       

        static void Main(string[] args)
        {
            //Calculator.Add(12,4);
            Calculator C=new Calculator();
            C.Add(1,2);
            C.Add(1.1f, 2);
            C.Add(1, 2.2f);
            C.Add(1, 2,4);
            C.Add(1.1f, 2.2f);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.day3
{
    class Armstrong
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            int num1 = num;
            int sum = 0;
            int c = 0;
            while (num > 0)
            {
                num = num / 10;
                c++;
            }
            num = num1;
            while (num > 0)
            {
                sum = sum + (int)Math.Pow(num, c);
            }
            Console.WriteLine("sum" + sum);
            num = num1;
            if (num == sum)
            {
                Console.WriteLine("Armstrong Number");
            }
            else
                Console.WriteLine("Not Armstrong Number");
        }
    }
}
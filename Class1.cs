using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch
{
    class Class1
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Mobile Number");
            long m = Convert.ToInt64(Console.ReadLine());
            long n = m;
            long d;
            int lastDigit, i;
           

            int[] freq = new int[10];

           for(i=0;i<10;i++)
            {
                freq[i] = 0;
            }
           
            while (m > 0)
            {
                lastDigit = (int)m % 10;
                m = m / 10;
                for (i = lastDigit; i < 10; i++)
                {
                    m = m % 10;
            
                        freq[lastDigit]++;
                    }

           
                for (i = 0; i < 10; i++)
                {
                    Console.WriteLine($"freq.{i}   {freq[i]}");
                }
            }
        }
    }
}

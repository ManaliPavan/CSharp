using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.Mar29
{
    class EvenInArray
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter array size");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[10];
            Console.WriteLine("Enter Array elements");
            int Even = 0;
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                if (arr[i] % 2 == 0)
                    Even++;
            }
            Console.WriteLine("Even numbers count is"+Even);
        }
    }
}

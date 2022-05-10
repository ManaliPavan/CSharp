using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.Mar29
{
    class DemoArray
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Enter array size");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[10];
            Console.WriteLine("Enter Array elements");
            for(int i=0;i<size;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=size-1;i>=0;i--)
            {
                Console.WriteLine($"arr[{i}]={arr[i]}");
            }
        }
    }
}

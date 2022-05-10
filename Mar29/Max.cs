using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.Mar29
{
    class Max
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter array size");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[10];
            Console.WriteLine("Enter Array elements");
           
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = arr[0];
            for (int i = 0; i < size; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Max of Number" + max);




            /////////or/////////
            ///
            Console.WriteLine("Enter array size");
            int size1 = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[10];
            Console.WriteLine("Enter Array elements");
            int max1 = int.MinValue;         //////Minvalue will assign minimum no (-214748...)
            for (int i = 0; i < size1; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
                if(arr[i]>max1)
                {
                    max1 = arr[i];
                }
            }

            Console.WriteLine("Max of Number" + max1);
        }
    }
}

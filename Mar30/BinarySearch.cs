 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.Mar30
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            int[] arr = { 11, 33, 55, 77, 99 };
            Console.WriteLine("Enter search element");
            int search = int.Parse(Console.ReadLine());
            int start = 0,end=arr.Length-1;
            int flag = 0;
            while(start<=end)
            {
                int mid = (start + end) / 2;
                if (arr[mid] == search)
                {
                    Console.WriteLine("Element found at pos"+mid);
                    flag = 1;
                    break;
                }
                else if (search > arr[mid])
                {
                    start = mid + 1;
                }
                else
                    end=mid - 1;
            }
            if(flag==0)
            {
                Console.WriteLine("element not present");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace AppleBatch.HashTable1
{
    class Numbers
    {
        static void Main(string[] args)
        {


            Hashtable nums = new Hashtable();
            nums.Add(1, "One");
            nums.Add(2, "Two");
            nums.Add(3, "Three");
            nums.Add(4, "Four");
            nums.Add(5, "Five");
            nums.Add(6, "Six");
            nums.Add(7, "Seven");
            nums.Add(8, "Eight");
            nums.Add(9, "Nine");
            nums.Add(10, "Ten");
         
        DictionaryEntry[] arr = new DictionaryEntry[nums.Count];
            nums.CopyTo(arr, 0);
            for(int i=0;i<arr.Length;i++)
            {
                dynamic k = arr[i].Key;
                if (k%2==0)
                    nums.Remove(k);
            }
            foreach(DictionaryEntry k in arr)
            {
                Console.WriteLine(k.Key+" "+k.Value);
            }

        }
    }
}

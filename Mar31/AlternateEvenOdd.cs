using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.Mar31
{
    class AlternateEvenOdd  
    {
        static void Main(string[] args)
        {

            int[] a = { 1, 2, 5, 8, 0 };
            int[] b = new int[a.Length];
            int e = 0,o = 0;
            for(int i=0;i<a.Length;)
            {
                while(e<a.Length && a[e]%2==1)   ///checking if e is less than a length and e position ele is odd
                {
                    e++;
                }
                if(e<a.Length)
                {
                    b[i] = a[e];
                    i++;
                    e++;
                }
                while (o < a.Length && a[o] % 2 == 0)   ///checking if e is less than a length and o position ele is even
                {
                    o++;
                }
                if (o < a.Length)
                {
                    b[i] = a[o];
                    i++;
                    o++;
                }

            }
        }
    }
}

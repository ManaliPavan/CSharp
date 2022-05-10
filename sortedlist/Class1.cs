//Print Array w/o duplicates but elements having duplicates only

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.sortedlist
{
    class Class1
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 1, 2,1 };
            
            for(int i=0;i<a.Length;i++)
            {
                int c = 0;
                for(int j=0;j<a.Length;j++)
                {
                    if (a[i] == a[j] && j < i)
                        break;
                    else if(a[i]==a[j])
                    c++;
                }
                if(c>1)
                Console.WriteLine(a[i]);
            }
        }
    }
}

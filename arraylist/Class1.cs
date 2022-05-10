using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace AppleBatch.arraylist
{
    class Class1
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("manali");
            al.Add(1234);
            al.Add("anvi");
            al.Add('a');
            Console.WriteLine("ArrayList added\n");
            for(int i=0;i<al.Count;i++)
            {
                Console.WriteLine(al[i]);
            }
            Console.WriteLine("\n\n\n\nadded with for loop\n");
            for(int i=0;i<10;i++)
            {
                al.Add(i);
            }
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(i+"   "+al[i]);
            }
            Console.WriteLine("\n\n\n\ninserted at position\n");
            al.Insert(3, "pavan");
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(i + "   " + al[i]);
            }
            Console.WriteLine("\n\n\n\nremoved (using remove and removeAt\n");
            al.Remove('a');
            al.RemoveAt(3);
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(i + "   " + al[i]);
            }
            Console.WriteLine("\n\n\n\nreversed\n");
            al.Reverse();
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(i + "   " + al[i]);
            }
            Console.WriteLine("\n\n\n\nremoverange\n");
            al.RemoveRange(1, 5);
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(i + "   " + al[i]);
            }
        }
    }
}

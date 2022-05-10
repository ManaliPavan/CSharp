using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.linkedlist
{
    class ll1
    {
        static void Main(string[] args)
        {
            LinkedList<int> ll = new LinkedList<int>();
            ll.AddLast(90);
            var n=ll.AddLast(100);
            ll.AddBefore(n, 900);
            ll.AddAfter(n, 700);
            ll.AddLast(120);
            ll.AddFirst(80);
            ll.AddFirst(70);
            ll.AddAfter(ll.First, 900);
            ll.AddAfter(ll.Last, 100);
            ll.AddBefore(ll.First, 900);
            ll.AddBefore(ll.Last, 100);
            ll.AddAfter(ll.Find(900), 400);
            ll.AddBefore(ll.Find(900), 400);
            foreach (int i in ll)
            {
                Console.WriteLine(i);
            }
        }
    }
}

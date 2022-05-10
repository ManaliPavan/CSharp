using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace AppleBatch.HashTable1
{
    class List
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "manali");
            ht.Add(2, "pavan");
            ht.Add(3, "anvi");
            ht.Add(4, "aarav");

            foreach(DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key+" "+d.Value);
            }
            ht.Remove(4);
            Console.WriteLine("After removing\n");
            foreach (DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key + " " + d.Value);
            }
            if (ht.ContainsKey(4))
            {
                ht["4"] = "prerna";
            }
            else
                ht.Add(4, "prerna");
            Console.WriteLine();
            foreach (DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key + " " + d.Value);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace AppleBatch.sortedlist
{
   
    class mycustomsort : IComparer
    {
        public int Compare(object o1, object o2)
        {
            StringBuilder sb1 = (StringBuilder)o1;
            StringBuilder sb2 = (StringBuilder)o2;
            return sb1.ToString().CompareTo(sb2.ToString());
        }
        
    }

    class Stud2Test
    {
        static void Main(string[] args)
        {

            SortedList s1 = new SortedList(new mycustomsort());
            s1.Add(new StringBuilder("Anvi"), 90);
            s1.Add(new StringBuilder("Janvi"), 90);
            s1.Add(new StringBuilder("Jivika"), 90);
            s1.Add(new StringBuilder("Sanvi"), 90);

            foreach (DictionaryEntry d in s1)
            {
                Console.WriteLine(d.Key + " " + d.Value);
            }

            Console.WriteLine();
            ArrayList al = new ArrayList();
            al.Add(new StringBuilder("Anvi"));
            al.Add(new StringBuilder("anjali"));
            al.Add(new StringBuilder("amit"));
            al.Add(new StringBuilder("akruti"));
            al.Sort(new mycustomsort());
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }

        }
    }


    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace AppleBatch.generic
{
   /* class AAA
    {
        object obj;
        public AAA()
        {

        }
        public void Add(object o)
        { obj= o; }
        public object Get()
        {
            return obj;
        }
    }
    class BBB<w>
    {
        w ob;
        public BBB()
        {

        }
        public void Add(w o)
        { ob = o; }
        public object Get()
        {
            return ob;
        }
    }
    class TT
    {
        static void Main(string[] args)
        {
            object o = new StringBuilder("om");
            AAA ob = new AAA();
            ob.Add(new string("om"));
            ob.Add(45.7);
            string s = (string)ob.Get();
            BBB<string> b = new BBB<string>();
            b.Add("sunil");
        }
    }
   */
    class l1
    {
        static void Main(string[] args)
        {
          /*  ArrayList al = new ArrayList();
            al.Add(90);
            al.Add(98);
            al.Add("Deepa");
            string s=(string)al[2];

            Stack s1 = new Stack();
            s1.Push(2);
            s1.Push(3);
            s1.Push("d");
            s1.Push("k");

            List<string> l = new List<string>();
            l.Add("A");
            l.Add("B");
            l.Add("C");
            l.Add("D");
            foreach(string d in l)
            {
                Console.WriteLine(d);
            }
            //we can add list ,stack(ie ienumerable to arraylist)
            al.AddRange(s1);
            al.AddRange(l);
          */
            int[] a = { 1, 2, 3 };
            int[] b = { 4, 6, 5 };
            var x = a.Concat(b);
           foreach(int q in x)
            {
                Console.WriteLine(q);
            }

        }
    }
}

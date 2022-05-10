using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.April12
{
    class P
    {
        public static void greet()
        { }
    }

    class C:P
    {
        public static void greet()
        { }
        static void Main(string[] args)
        {
            C.greet();
        }
    }


    class Think
    {
        private int a=10;
        protected int b=20;    //current assembly and other assembly
        private protected int c = 30;     //subclass->current assembly only
        protected internal int d = 900;     //protected in subclass,curr assem everywhere + subclass in otherclass
        internal int e = 87;             //

    }
    class GG
    {
        static void Main(string[] args)
        {

        }
    }
}

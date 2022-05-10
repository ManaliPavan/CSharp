using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.April12
{
    class Demo
    {
        public virtual void m1()
        { }

        internal virtual void m2()
        { }
        static void Main(string[] args)
        {
            Console.WriteLine("Parent");
        }

        public void m3()
        { }

        /*
        static public virtual void mystatic()
                { }
            
        */
    }
        class ChildDemo1 : Demo
        {
            //method hidding
            public void m1()
            { }

            //method ovverride

            internal override void m2()
            { }

            public void m4()
            { }
            /*
            
            static public override void mystatic()                 //static cant be overriden
                    { }
             
             */

        static public void mystatic1()
        { }
        }
            class SubChildDemo1 : ChildDemo1
            {
                public void m1(int a)           //parent:child:subchild
                {

                }

                public void m3()                
                { }

                public void m4()
                { }
            }
            sealed class ChildDemo2 : Demo
            {

            }

            class SubChildDemo2 : Demo
            {

            }
            /*   class SubChildDemo2:ChildDemo2    ////it cant be derive from sealed class ChildDemo
             *   {
             *   }
             *   */

            class Test
            {
                static void Main(string[] args)
                {
                    ChildDemo1 c1 = new ChildDemo1();
                    c1.m1();
                    Demo d1 = new Demo();
                    d1.m3();
                    Object o1 = new Demo();           ///object is parent of all classes so it is valid
                    // o1.m1();                         //it is not valid becoz m1 is not actually in object it is in Demo it will give error at compile time
                    Demo d2 = new ChildDemo1();
                    Demo dd = (Demo)(o1);              //type casting
                    dd.m1();
                }
            }
}
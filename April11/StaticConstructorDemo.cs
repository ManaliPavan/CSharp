using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.April11
{
    class StaticConstructorDemo
    {
        string productname;
        int pprice;
        static string category;

        internal StaticConstructorDemo()
        {
            Console.WriteLine("Default");
        }
        public StaticConstructorDemo(string productname, int pprice)
        {
            Console.WriteLine("Parametrized Constructor");
            this.productname = productname;
            this.pprice = pprice;
        }

        static StaticConstructorDemo()
        {
            Console.WriteLine("Static Constructor");
            category = "any";
            Console.WriteLine(category);
        }
    }
    class TestStaticConstructor
    {
        static void Main(string[] args)
        {
            StaticConstructorDemo s1 = new StaticConstructorDemo("era",230);
            StaticConstructorDemo s2= new StaticConstructorDemo("bag",5000);
            StaticConstructorDemo s3 = new StaticConstructorDemo("bottle",800);
            StaticConstructorDemo s4 = new StaticConstructorDemo();
            
        }
    }
}

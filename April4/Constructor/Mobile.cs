

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.April4.Constructor
{
    class Mobile
    {
        //string mobilename;
       // int price;
        public Mobile()
        {
            Console.WriteLine("mobile created");
        }

        class TestMobile
        {
            static void Main(string[] args)
            {
                Mobile m1 = new Mobile();
                Mobile m2 = new Mobile();
                Mobile m3 = new Mobile();
                Mobile m4 = new Mobile();
            }
        }
    }
}


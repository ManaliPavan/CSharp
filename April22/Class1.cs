//check if string 2 can be formmed from string 1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.April22
{
    class Class1
    {
        static void Main(string[] args)
        {
            string s1 = "prathmesh";
            string s2 = "team";
            bool isPresent=true;
            for (int i = 0; i < s2.Length; i++)
            {
                if(s1.IndexOf(s2[i])==-1)
                {
                    isPresent = false;
                    break;
                }
            }
            if(isPresent)
            {
                Console.WriteLine("Possible");
            }
            else
                Console.WriteLine("Not Posssible");
        }
    }
}

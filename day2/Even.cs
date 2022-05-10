using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch
{
    class Even
    {
        static void Main(string[] args)
        {
            for(int i = 101;i<=120;i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
            }
            for(int i=102;i<=120;i=i+2)
            {
                Console.WriteLine(i);
            }

        }
    }
}

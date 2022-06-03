using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace AppleBatch.thread
{
    public class Class1
    {
        static void M1()
        {
            Console.WriteLine(" m1 start");
            for(int i=0;i<=10;i++)
            {
                Console.WriteLine("Thread :"+Thread.CurrentThread.Name+" : in m1 : " +i);
                //Thread.Sleep(3000);
            }
            Console.WriteLine("m1 ends");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("main starts");
            Thread.CurrentThread.Name = "Main";
            Thread t1 = new Thread(M1);
            t1.Start();
            t1.Name = "Child 1";
            Thread t2 = new Thread(M1);
            t2.Name = "Child 2";
            t2.Start();
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("thread : "+Thread.CurrentThread.Name+" : in main : " + i);
            }
            Console.WriteLine("main ends");

        }
    }
}

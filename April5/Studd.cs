//chainning

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.April5
{
    class Studd
    {

        int sid, percent, passyear;
        string name, email;

        public Studd()
        {
            //default constructor
        }
        public Studd(int id, string name, int p, int y, string e) : this(id, name, p,y)
        {
            //constructor with all parameter
            Console.WriteLine("in 5 parameterized constructor");
            email = e;
            
        }
        public Studd(int id, string name, int p, int y):this(id,name,p)
        {
            //constructor with -1 parameter
            Console.WriteLine("in 4 parameterized constructor");
            passyear = y;
          
        }
        public Studd(int id, string name, int p):this(id,name)
        {
            //constructor with -2 parameter
            Console.WriteLine("in 3 parameterized constructor");
            percent = p;
            
        }
        public Studd(int id, string name):this(id)
        {
            //constructor with -3 parameter
            Console.WriteLine("in 2 parameterized constructor");
            this.name = name;
            
        }
        public Studd(int id)
        {
            //constructor with -4parameter
            Console.WriteLine("in 1 parameterized constructor");
            sid = id;
           
        }
    }
    class TestStudd
    {
        static void Main(string[] args)
        {
            Studd s1 = new Studd(1,"om",90,2021,"abc@gmail.com");
            Console.WriteLine("\n\n");
            Studd s2 = new Studd(1, "om", 90, 2021);
            Console.WriteLine("\n\n");
            Studd s3 = new Studd(1, "om", 90);
            Console.WriteLine("\n\n");
            Studd s4 = new Studd(1, "om");
        }
    }
}
/*
        in 1 parameterized constructor
        in 2 parameterized constructor
        in 3 parameterized constructor
        in 4 parameterized constructor
        in 5 parameterized constructor



        in 1 parameterized constructor
        in 2 parameterized constructor
        in 3 parameterized constructor
        in 4 parameterized constructor



        in 1 parameterized constructor
        in 2 parameterized constructor
        in 3 parameterized constructor



        in 1 parameterized constructor
        in 2 parameterized constructor
*/

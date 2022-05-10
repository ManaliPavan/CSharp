using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch
{
    class inputs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name");
            String name = Console.ReadLine();
            Console.WriteLine("Enter Age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Height");
            float height = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("enter gender(m/f)");
            char gender = Convert.ToChar(Console.Read());    
            Console.ReadLine();                                  //as due to read() it gives error (system.formatException error at next readLine)
            Console.WriteLine("Enter mobile number");
            long mob = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("_____________________________");
            Console.WriteLine("Details:");
            Console.WriteLine("_____________________________");
            Console.WriteLine("Name: "+name+"\nAge: "+age+"\nHeight: "+height+"\nGender: "+gender+"\nMobile No: "+mob);
            Console.WriteLine("_____________________________");
        }
    }
}

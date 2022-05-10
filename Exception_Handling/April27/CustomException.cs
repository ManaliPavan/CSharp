//invalid user and password exception

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.Exception_Handling.April27
{
    class CustomException
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name and password");
            string u = Console.ReadLine();
            string p = Console.ReadLine();
            if (u == "user" && p == "password")
            {
                Console.WriteLine("login in successful..");
            }
            else
            {
                try
                {
                    throw new InvalidLoginException("Please enter correct Login details");
                }
                catch(InvalidLoginException e)
                {
                    Console.WriteLine(e.Message);
                }

                
            }
            Console.WriteLine("thank you");
        }
        class InvalidLoginException:ApplicationException     ///it can be Exception,SystemException,ApplicationException
        {
            
            public InvalidLoginException(string m):base(m)   ////if we didn't write base(m) our exception message will not be displayed it will display default message in catch as error in application //base passes it to parent class from custom exception class
            { 
                
            }
        }
    }
}

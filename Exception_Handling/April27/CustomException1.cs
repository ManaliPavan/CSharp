//invalid mobile number exception

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.Exception_Handling.April27
{
    class CustomException1
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter mobile number");
                long m = Convert.ToInt64(Console.ReadLine());
                
                int count = 0;
                while (m != 0)
                {
                    
                    count++;
                    m = m / 10;
                }
                
                if (count == 10)
                {
                    Console.WriteLine("valid mobile number");
                }
                else
                {
                    try
                    {
                        throw new InvalidMobException("Exception : Invalid Mobile Number");
                    }
                    catch (InvalidMobException e)
                    {
                        Console.WriteLine(e.Message);
                        //Console.WriteLine(e);
                    }
                }
            }
            /*
            catch(FormatException)
            {
                Console.WriteLine("Exception : Invalid I/P");
            }*/
            catch(Exception e)
            {
                Console.WriteLine("Exception : {"+e.Message+"}");
               
            }
        }
    }
    class InvalidMobException : ApplicationException
    {
        public InvalidMobException(string m) : base(m) 
        {

        }

        ///we want to print using only e then add this
       /* public override string ToString()
        {
            return "Errorrr..";
        }*/

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.Exception_Handling.April27
{
    class Class
    {
        static int m1()
        {
            Console.WriteLine("Enter i/p");

            try
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Division{a / b}");
                return a / b;

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exception : Divide by Zero");

            }
            /*
            catch (FormatException)
            {
                Console.WriteLine("Excetion : I/P is wrong");
            }*/
            catch (Exception e)
            {
                Console.WriteLine("Excetion : Error" + "  {" + e.Message + "}");
            }
            finally
            {
                Console.WriteLine("in finally");
            }
            return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main");
            int ans = m1();
            Console.WriteLine($"Division {ans}");
        }
    }
}

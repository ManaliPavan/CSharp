using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.Exception_Handling.April27
{
    class Calc
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter i/p");
            
            try
            {   
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Addition{a + b}");
                Console.WriteLine($"Substraction{a - b}");
                Console.WriteLine($"Division{a / b}");
                

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
            catch(Exception e)
            {
                Console.WriteLine("Excetion : Error"+"  {"+e.Message+"}");
            }
            finally
            {
                Console.WriteLine("in finally");
            }
            
        }
    }
}

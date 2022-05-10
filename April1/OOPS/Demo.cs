using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.April1.OOPS
{
    class Demo
    {
        class student
        {//blueprint
            //instance variables
            int sid, percent;
            string name,qualification;
            int passOutYear;
            long mobile;
       
        class Trainer {  /// <summary>
                         /// /we can create object of one class in main inside 
                         /// other class  or in main
                         /// </summary>

                static void Main(string[] args)
                {//object
                    student s1 = new student();
                   
                    int a; //local variable
                    s1.sid = 101;
                    s1.name = "mani";
                    s1.qualification = "BE";
                    s1.passOutYear = 2019;
                    s1.mobile = 1234567890;
                    s1.percent= 70;

                    student s2 = new student();
                    s2.sid = 101;               ///hardcoded values 
                    s2.name = "pavan";
                    s2.qualification = "BE";
                    s2.passOutYear = 2018;
                    s2.mobile = 1234567899;
                    s2.percent = 80;


                    student s3 = new student(); 
                    ///values from user
                    Console.WriteLine("Enter details:(sid, percent, name, qualification,passOutYear,mobile) ");
                    s2.sid=Convert.ToInt32(Console.ReadLine());
                    s2.percent = Convert.ToInt32(Console.ReadLine());
                    s2.name = Console.ReadLine();
                    s2.qualification = Console.ReadLine();
                    s2.passOutYear = Convert.ToInt32(Console.ReadLine());
                    s2.mobile = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}

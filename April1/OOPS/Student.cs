using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.April1.OOPS
{
    class Student
    {
        public int sid, percent;
        public string name, qualification;
        public int passOutYear;
        public long mobile;
        public static String Trainer;
        //public static String Trainer = "Deepa";    

        //static method
        public static void TrainerName()
        {
            Console.WriteLine("Enter Trainer Name");
            String Trainer = Console.ReadLine();
        }
       
            //instance method
        public void accept()
            {
            Console.WriteLine("Enter details:(sid, percent, name, qualification,passOutYear,mobile) ");
            sid = Convert.ToInt32(Console.ReadLine());
            name = Console.ReadLine();
            percent = Convert.ToInt32(Console.ReadLine());
            qualification = Console.ReadLine();
            passOutYear = Convert.ToInt32(Console.ReadLine());
            mobile = Convert.ToInt32(Console.ReadLine());

        }
        public void display()
        {
            Console.WriteLine($"Student Details:\nStudent Id:{sid}\nName:{name}\nPercentage:{percent}\nQualification:{qualification}\nPassOutYear:{passOutYear}\nMobileNumber:{mobile}\nTrainer:{Trainer}");

        }
        static void Main(string[] args)
        {
            //Student.Trainer = "Deepa";
            Student S1 = new Student();
            S1.accept();
            S1.display();
            Student S2 = new Student();
            S2.accept();
            S2.display();
        }
    }
}

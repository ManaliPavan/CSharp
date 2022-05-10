using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.April5
{
    class Student
    {
        int rollno;
        string name;
        string gender;
        static int c;
        public Student()
        {
            c++;
            rollno = c;
            //return rollno;
   
        }
        public void SetName(string n)
        {
            name = n;
        }
        public string GetName()
        {
            return name;
        }
        public void SetGender(string g)
        {
            gender = g;
        }
        public string GetGender()
        {
            return gender;
        }
    }
    class TestStudent
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Console.WriteLine(  "enter student name");
            s1.SetName(Console.ReadLine());
            Console.WriteLine("Enter gender");
            s1.SetGender(Console.ReadLine());
            Console.WriteLine($"\nStudent Name{s1.GetName()}\nStudent's Gender{s1.GetGender()}");
            Student s2 = new Student();
            Console.WriteLine("enter student name");
            s2.SetName(Console.ReadLine());
            Console.WriteLine("Enter gender");
            s2.SetGender(Console.ReadLine());
            Console.WriteLine($"Student Details:\nStudent Name{s2.GetName()}\nStudent's Gender{s2.GetGender()}");
            Student s3 = new Student();
            Console.WriteLine("enter student name");
            s3.SetName(Console.ReadLine());
            Console.WriteLine("Enter gender");
            s3.SetGender(Console.ReadLine());
            Console.WriteLine($"Student Details:\nStudent Name{s3.GetName()}\nStudent's Gender{s3.GetGender()}");
        }
    }
}

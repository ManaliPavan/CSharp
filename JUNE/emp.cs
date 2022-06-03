using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.JUNE
{
    class emp
    {
        public static int count;
        public int empid;
        public string empname;
        public int salary;
        public emp(string empname,int salary)
        {
            count++;
            empid = count;
            this.empname = empname;
            this.salary = salary;
        }

        public  int Empid { get => empid; set => empid = value; }
        public string Empname { get => empname; set => empname = value; }

        public override string ToString()
        {
            return $"ID:{empid} \n NAME :{Empname} \n Salary :{salary}";
        }
        public static void ShowCount()
        {
            Console.WriteLine($"Total count {count}");
        }
    }
    class T1
    {
        static void Main(string[] args)
        {
            
            emp e1 = new emp("manali",20000);
            Console.WriteLine(e1);
            emp e2 = new emp("sonali",100000);
            Console.WriteLine(e2);
            emp.ShowCount();
        }
    }  
}

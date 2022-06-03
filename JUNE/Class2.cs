using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.JUNE
{
    public delegate void mydel(string name);
    class del
    {

        public static void upper(string name)
        {
            Console.WriteLine($"UPPERCASE   " + name.ToUpper());
        }
        public static void lower(string name)
        {
            Console.WriteLine($"lowercase   " + name.ToLower());
        }
    }
    class Class2
    {
        static void Main(string[] args)
        {
            mydel multi = del.upper;
            // multi("manali");
            multi += del.lower;
            multi("SONALI");

            Delegate[] list = multi.GetInvocationList();
            foreach(Delegate item in list)
            {
                Console.WriteLine(item.Method);
                item.DynamicInvoke("Pune");
            }

        }
    }

    //delegate and event
    public delegate void Mydel();
    public class Student
    {
        public event Mydel Fail;
        public event Mydel Distinction;

        public void AcceptMarks(int marks)
        {
            if(marks<40)
            {
                Fail();  ///call to event /raise to event
            }
            else if(marks>=75)
            {
                Distinction();
            }
            else
                Console.WriteLine($"Your Score is {marks}");
        }
    }

    class STest
    {
        static void FailMsg()
        {
            Console.WriteLine("You are fail !");
        }
        static void DistinctionMsg()
        {
            Console.WriteLine("You are pass with distinction");
        }
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Fail += new Mydel(FailMsg);
            s1.Distinction += new Mydel(DistinctionMsg);
            s1.AcceptMarks(34);
        }
    }

    public delegate void mydel1();
    public class Bank
    {
        public event mydel1 ZeroBalance;
        public event mydel1 InSufficient;

        double balance;

        
        public Bank()
        {
           balance = 20000;
        }

        public void AddAmt(double amt)
        {
            balance += amt;
            Console.WriteLine($"Current Balance : { balance} \t Credited Amount : {amt}");
        }

        public void RemoveAmt(double amt)
        {
            if (balance > 0)
            {
                if (amt <= balance)
                {
                    balance -= amt;
                    Console.WriteLine($"Current Balance : {balance} \t Deducted Amount: {amt}");
                }
                else
                    InSufficient();
            }
            else
                ZeroBalance();
        }
    }
    class BTest
    {
       
            static void ZeroBal()
            {
                Console.WriteLine("Current Balance is Zero.....");
            }

            static void InsufficientBal()
            {
                Console.WriteLine("Current Balance is not sufficient to process further..");
            }
        static void Main(string[] args)
        {
            Bank b1 = new Bank();
            b1.ZeroBalance += new mydel1(ZeroBal);
            b1.InSufficient += new mydel1(InsufficientBal);
            b1.AddAmt(4000);
            b1.RemoveAmt(6000);

        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.April1.OOPS
{
    class Demo2
    {
        class student
        {//blueprint
            //instance variables
            public int sid, percent;
            public string name, qualification;
            public int passOutYear;
            public long mobile;

            public void display()        ///function declaration
            {
                Console.WriteLine("Hello");
            }
            
            public int add(int a,int b)
            {
                int sum = a + b;
                return sum;
            }
            public void add1(int a, int b)
            {
                int sum = a + b;
                Console.WriteLine(sum);
            }
            public bool isEven(int num)
            {
                if (num % 2 == 0)
                    return true;
                else 
                return  false;
            }


            static void Main(string[] args)
            {
                student s1 = new student();
                s1.display();    ///function call
                int answer = s1.add(20, 60);
                s1.add1(20, 70);
                Console.WriteLine("sum" + answer);
                bool b = s1.isEven(34);
            }
            }
        }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace AppleBatch.arraylist
{
    class Numbers
    {
        static void Main(string[] args)
        {


            ArrayList nums = new ArrayList();
            nums.Add("One");
            nums.Add("Two");
            nums.Add("Three");
            nums.Add("Four");
            nums.Add("Five");
            nums.Add("Six");
            nums.Add("Seven");
            nums.Add("Eight");
            nums.Add("Nine");
            nums.Add("Ten");
            nums.Add("One");
            nums.Add("Two");
            nums.Add("Five");
            nums.Add( "Five");
            nums.Add("Five");
            nums.Add("Five");
            nums.Add("Five");
            int Tcount = 0;
            int maxcount = 0;
            string maxname = "";
            //total elements in arraylist
            foreach (string d in nums)
            {
                if (nums.Contains(d))
                    Tcount++;
            }
            Console.WriteLine(Tcount);

            //max duplicates in arraylist
            foreach (string d in nums)
            {
                int c = 0;
                foreach (string dd in nums)
                {
                    if (d == dd)
                    {
                        c++;
                    }
                   
                }
                if(maxcount<c)
                {
                    maxname = d;
                    maxcount = c;
                }
           
        }
            Console.WriteLine(maxname+"  "+maxcount);
            //remove duplicates

            foreach(string d1 in nums)
            {
                int c1 = 0;
                foreach(string d2 in nums)
                {
                    if(d1==d2)
                    {
                        c1++;
                    }
                   
                }
                if (c1 != 1)
                {
                    nums.Remove(d1);
                }
            
            }
            foreach(string v in nums)
            {
                Console.WriteLine(v);
            }
        }
    }
}

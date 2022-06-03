//string s="manali";,is palindrome/substring is palindrome

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch
{
    class ClassMock
    {

        public static  bool palindrome(string s)
        {
            string reverse = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                reverse = reverse + s[i].ToString();
            }
            if(s==reverse)
            return true;
            else 
                return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name");
            string s = Console.ReadLine();
            string s_copy = s;
            string [] sub1 = new string[s.Length];   //removing from left
            string[] sub2 = new string[s.Length];    //removing from right
            string[] sub3 = new string[s.Length];     //removing from right on sub1
            string[] sub4 = new string[s.Length];
            int k = 2;
            int len = 2;
            bool r = palindrome(s);
                if (r==true)
                    Console.WriteLine($"String is Palindrome");
                else
                    Console.WriteLine($"String {s} is not Palindrome");
            //sub1
            k = 2;
            
                for (int i = 0; i < sub1.Length;)
                {
                    s = s_copy;

                    if (k > s.Length - len)
                        goto CONTINUE;
                    for (int j = s.Length - k; j >= 0; j--)
                        sub1[i] = sub1[i] + s[j];
                    k++;
                    i++;
                }
            
        CONTINUE:
            //sub2
                k = 1;
                for (int i = 0; i < sub2.Length;)
                {
                    s = s_copy;
                    
                    if (k > s.Length-(s.Length/2))
                        goto CONTINUE1;
                    for (int j = k; j <= s.Length - 1; j++)
                        sub2[i] = sub2[i] + s[j];
                    k++;
                    i++;
                }
            
            CONTINUE1:
            //sub3
                k = 1;
               
                for (int i = 0; i < sub3.Length;)
                {
                    s = s_copy;
                    if (k > (s.Length+1)-s.Length)
                         goto CONTINUE2;
                    for (int j = k; j <= s.Length - 3; j++)
                        sub3[i] = sub3[i] + s[j];
                    k++;
                    i++;
                }
            
        CONTINUE2:
            //sub4
            k = 2;
            for (int i = 0; i < sub4.Length;)
            {
                s = s_copy;
                if (k > s.Length-4)
                    goto CONTINUE4;
                for (int j = s.Length - k; j >= 2; j--)
                    sub4[i] = sub4[i] + s[j];
                k++;
                i++;
            }

        CONTINUE4:
            int l = 0;
             for ( l = 0; l < sub1.Length; l++)
             {
                if (sub1[l] != null)
                {
                    r = palindrome(sub1[l].ToString());
                    if (r == true)
                        Console.WriteLine(sub1[l] + " is palindrome");
                } 
             }
            for ( l = 0; l < sub2.Length; l++)
            {
                if (sub2[l] != null)
                {

                    r = palindrome(sub2[l].ToString());
                    if (r == true)
                        Console.WriteLine(sub2[l] + " is palindrome");
                }  
            }
            
            for ( l = 0; l < sub3.Length; l++)
            {
                if (sub3[l] != null)
                {

                    r = palindrome(sub3[l].ToString());
                    if (r == true)
                        Console.WriteLine(sub3[l] + " is palindrome");
                }  
            }
            for (l = 0; l < sub4.Length; l++)
            {
                if (sub4[l] != null)
                {
                    r = palindrome(sub4[l].ToString());
                    if (r == true)
                        Console.WriteLine(sub4[l] + "  is palindrome");
                }
            }

        }
    }
    }

/*
o/p :  Enter name
       manali
       String manali is not Palindrome
       ana is palindrome
*/

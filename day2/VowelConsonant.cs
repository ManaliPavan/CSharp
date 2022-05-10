using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch
{
    class VowelConsonant
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter character");
            char ch = Convert.ToChar(Console.Read());
            switch(ch)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u': Console.WriteLine("Vowel");
                    break;
                default: Console.WriteLine("Consonant");
                    break;
                    
            }
        }
    }
}

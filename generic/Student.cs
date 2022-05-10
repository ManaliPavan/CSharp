using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.generic
{
    class Student1
    {
        internal class Student:IComparable<Student>
        { string sname;
            int percent;

            public Student(string sname, int percent)
            {
                this.Sname = sname;
                this.Percent = percent;
            }

            public int CompareTo(Student s2)
            {
                return sname.CompareTo(s2.sname);
            }
            public override string ToString()
            {
                return $"Name={sname} Percentage={percent}";

            }
            public string Sname { get => sname; set => sname = value; }
            public int Percent { get => percent; set => percent = value; }
        }
        class sortByPercent : IComparer<Student>
        {
        public int Compare(Student x,Student y)
            {
                return x.Percent.CompareTo(y.Percent);
            }
        }
        static void Main(string[] args)
        {
            SortedList<Student, string> sl = new SortedList<Student, string>();  //it will sort according to name(Compare:IComparable)
         // SortedList<Student, string> sl = new SortedList<Student, string>(new sortByPercent());  //sorted according to percent(custom class:IComparer)
            
            sl.Add(new Student("Surya", 92), "Prorigo");
            sl.Add(new Student("Sanket", 94), "Kanka");
          
            foreach (KeyValuePair<Student,string>  k in sl)
            {
                Console.WriteLine(k.Key +" "+k.Value);
            }
        }
    }
}

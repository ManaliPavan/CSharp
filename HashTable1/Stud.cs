using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AppleBatch.HashTable1
{
    class Stud
    {
        int studid;
        string sname, course,branch;
        int per;
        public Stud(int studid, string sname, string course, string branch, int per)
        {
            this.Studid = studid;
            this.Per = per;
            this.Sname = sname;
            this.Course = course;
            this.Branch = branch;
        }

        public override string ToString()
        {
            return $"Student_ID {studid} Student_Name {sname} Course {course} branch {branch}";
        }

        public override bool Equals(object obj)
        {
            Stud stud = (Stud)obj;
            return 
                   studid == stud.studid &&
                   sname == stud.sname &&
                   course == stud.course &&
                   branch == stud.branch &&
                   per == stud.per;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(studid, sname, course, branch, per);
        }

        public int Studid { get => studid; set => studid = value; }
        public int Per { get => per; set => per = value; }
        public string Sname { get => sname; set => sname = value; }
        public string Course { get => course; set => course = value; }
        public string Branch { get => branch; set => branch = value; }

        
    }
    class College
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(new Stud (1, "Anvi", "Engg", "Mech", 80),1000);
            ht.Add(new Stud(2, "Janvi", "Engg", "Com.Science", 89), 2000);
            ht.Add(new Stud(3, "Jivika", "BSc", "Agri", 90), 3000);
            ht.Add(new Stud(4, "Sanvi", "Bsc", "Com.Science", 85), 4000);
            ht.Add(new Stud(5, "Manali", "Engg", "Com.Science", 50), 5000);
            ht.Add(new Stud(6, "Sonali", "BSc", "Com.Science", 60), 6000);
       //     ht.Add(new Stud(1, "Anvi", "Engg", "Mech", 80), 1000);        //System.ArgumentException: 'Item has already been added

            foreach (DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key+" "+d.Value);
            }
        }
    }
}

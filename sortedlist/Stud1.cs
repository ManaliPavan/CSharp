using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace AppleBatch.sortedlist
{
    class Stud1:IComparable
    {
        string sname;
        int percent;
        string city;

        public Stud1(string sname, int percent, string city)
        {
            this.Sname = sname;
            this.Percent = percent;
            this.City = city;
        }

        public string Sname { get => sname; set => sname = value; }
        public int Percent { get => percent; set => percent = value; }
        public string City { get => city; set => city = value; }

        public int CompareTo(object o)
        {
            Stud1 s2 = (Stud1)o;
            if (City.CompareTo(s2.City) == 0)
                return this.Sname.CompareTo(s2.Sname);
            else
                return this.City.CompareTo(s2.City);
            // return s2.percent.CompareTo(this.percent); ///descending
        }
        public override string ToString()
        {
            return $"sname {Sname} Percentage{Percent} City{City}";
        }
    }
    class Stud1Test
    {
        static void Main(string[] args)
        {

            SortedList ss = new SortedList();
            ss.Add(new Stud1("Anvi", 80, "Pune"), "Java");
            ss.Add(new Stud1("Janvi", 89, "munbai"), 2000);
            ss.Add(new Stud1("Jivika", 90, "Delhi"), 3000);
            ss.Add(new Stud1("Sanvi", 85, "Ravet"), "Java");

            foreach (DictionaryEntry d in ss)
            {
                Console.WriteLine(d.Key + " " + d.Value);
            }

                // Console.WriteLine("Anvi".CompareTo("Sanvi"));
            }
        }

}

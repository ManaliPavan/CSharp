using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.April6.containmen
{
    class Flat
    {
        int flatno;
        string buildingname;
        Member memberobj;

        public Flat()
        {
        }

        public Flat(int flatno, string buildingname, Member memberobj)
        {
            this.Flatno = flatno;
            this.Buildingname = buildingname;
            this.Memberobj = memberobj;
        }

        public int Flatno { get => flatno; set => flatno = value; }
        public string Buildingname { get => buildingname; set => buildingname = value; }
        public Member Memberobj { get => memberobj; set => memberobj = value; }
    }
    class Member
    {
        string membername;
        char gender;
        int age;
        string profession;

        public Member()
        {
        }

        public Member(string membername, char gender, int age, string profession)
        {
            this.Membername = membername;
            this.Gender = gender;
            this.Age = age;
            this.Profession = profession;
        }

        public string Membername { get => membername; set => membername = value; }
        public char Gender { get => gender; set => gender = value; }
        public int Age { get => age; set => age = value; }
        public string Profession { get => profession; set => profession = value; }
    }
    class TestFlat
        {
        static void Main(string[] args)
        {
            Flat f1 = new Flat(1,"Royal",new Member("Manali",'f',25,"xyz"));
            Flat f2 = new Flat(2, "Stone", new Member("Sonali", 'f', 29, "abc"));
            Console.WriteLine($"Flat Details:\nFlat No:{f1.Flatno}\nBuilding Name: {f1.Buildingname}\nOwner:\tName: {f1.Memberobj.Membername}\n\tGender: {f1.Memberobj.Gender}\n\tAge: {f1.Memberobj.Age}\n\tProfession: {f1.Memberobj.Profession} ");
            Console.WriteLine("\n");
            Console.WriteLine($"Flat Details:\nFlat No:{f2.Flatno}\nBuilding Name: {f1.Buildingname}\nOwner:\tName: {f2.Memberobj.Membername}\n\tGender: {f1.Memberobj.Gender}\n\tAge: {f2.Memberobj.Age}\n\tProfession: {f2.Memberobj.Profession} ");
        }
    }
}

/*
 Flat Details:
Flat No:1
Building Name: Royal
Owner:  Name: Manali
        Gender: f
        Age: 25
        Profession: xyz


Flat Details:
Flat No:2
Building Name: Royal
Owner:  Name: Sonali
        Gender: f
        Age: 29
        Profession: abc

*/

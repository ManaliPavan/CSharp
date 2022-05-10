using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.April6.containmen
{
    class Student
    {
        int studid;
        string name;
        int percent;
        Batch batch1 = new Batch();
        Address addr = new Address();

        public Student()
            {
            }
        public Student(int studid, string name, int percent, Batch batch1, Address addr)
        {
            this.Studid = studid;
            this.Name = name;
            this.Percent = percent;
            this.Batch1 = batch1;
            this.Addr = addr;
        }

        public int Studid { get => studid; set => studid = value; }
        public string Name { get => name; set => name = value; }
        public int Percent { get => percent; set => percent = value; }
        public Batch Batch1 { get => batch1; set => batch1 = value; }
        public Address Addr { get => addr; set => addr = value; }
    }
    class Batch
    {
        string batchname;
        string subject;

        public Batch()
        {
        }

        public Batch(string batchname, string subject)
        {
            this.batchname = batchname;
            this.subject = subject;
        }

        public string Batchname { get => batchname; set => batchname = value; }
        public string Subject { get => subject; set => subject = value; }
    }

    class Address
    {
        string street;
        string city;

        public Address()
        {
        }

        public Address(string street, string city)
        {
            this.street = street;
            this.city = city;
        }

        public string Street { get => street; set => street = value; }
        public string City { get => city; set => city = value; }
    }
    class TestStudent
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Studid = 101;
            s1.Name = "Manali";
            s1.Percent = 100;
            s1.Batch1.Batchname = "Apple";
            s1.Batch1.Subject = "C#";
            s1.Addr.Street = "MG Road";
            s1.Addr.City = "Pune";
            Console.WriteLine($"Student Details:\nStudent id: {s1.Studid}\n Student Name: {s1.Name}\n Student's Percentage: {s1.Percent}\n Student Batch: {s1.Batch1.Batchname}\n Subject: {s1.Batch1.Subject}\n Address details:\n Street: { s1.Addr.Street}\nCity: {s1.Addr.City}");
            /*           Address a1 = new Address("XY Road","Mumbai");
                       Batch b1 = new Batch("Microsoft", "Java");
                       Student s2 = new Student(2, "Ratna",43,b1,a1);
           ////or////             
                       Student s3 = new Student(3, "sona", 54, new Batch("Microsoft","PHP"), new Address("fgd", "nashik"));    //for 85-88 dont write new Batch() ,new Address() in Student class instance variable
            */

            Student s2 = s1;
            s2.Name = "Deepa";

            Console.WriteLine(s1.Name);
            Console.WriteLine(s2.Name);
            }
    }
}


/*
    Student Details:
    Student id: 101
    Student Name: Manali
    Student's Percentage: 100
    Student Batch: Apple
    Subject: C#
    Address details:
    Street: MG Road
    City: Pune

*/
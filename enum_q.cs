using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch
{
    enum Role
    {
        Admin,Developer,Tester
    }
    class Emp
    {
        string name;
        Role role;

        public Emp()
            {

            }
        public Emp(string name, Role role)
        {
            this.Name = name;
            this.Role = role;
        }

        public string Name { get => name; set => name = value; }
        internal Role Role { get => role; set => role = value; }

        public override string ToString()
        {
            return $"Name : {name} Role : {role}";
        }

        static void Main(string[] args)
        {
            Emp e = new Emp();
            Console.WriteLine("Enter name");
            string nm = Console.ReadLine();
            Console.WriteLine("Enter Role from following..");
            foreach(var d in Enum.GetNames<Role>())
                Console.WriteLine(d);
            Console.WriteLine("Enter role");
            string choice = Console.ReadLine();
            e.name = nm;
            e.role = Enum.Parse<Role>(choice);
            Console.WriteLine(e);
        }
    }
}

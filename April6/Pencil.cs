using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.April6
{
    class Pencil
    {
        string brand;

        public string Brand
        {
            set { brand = value; }
            get { return brand; }
        }

        public int Price
        {
            set;
            get;
        }
        public Pencil():this("camalin",20)
        {
            Console.WriteLine("Default");
        }
        public Pencil(string b,int p)
        {
            brand = b;
            Price = p;
        }
    }
    class TestPencil
    {
        static void Main(string[] args)
        {
            Pencil p = new Pencil();
            Console.WriteLine($"Pencil name:{p.Brand}\nprice:{p.Price}");
            Pencil p1 = new Pencil();
            p1.Brand = "Doms";
            p1.Price = 10;
            Console.WriteLine($"Pencil name:{p1.Brand}\nprice:{p1.Price}");
            Pencil p2 = new Pencil();
            p2.Brand = "Apsara";
            p2.Price = 20;
            Console.WriteLine($"Pencil name:{p2.Brand}\nprice:{p2.Price}");
        }
    }
}

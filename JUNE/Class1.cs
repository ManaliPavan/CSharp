using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.JUNE
{
    public class Employee
    {
        public int id;
        public string name;
        public double salary;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Salary { get => salary; set => salary = value; }

        public Employee(int id, string name, double salary)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
        }

        public override string ToString()
        {
            return $"ID : {id} \n NAME : {name}\n SALARY : {salary}";
        }

        static void Main(string[] args)
        {
            Employee[] e = new Employee[]
            {
            new Employee(1,"monali",12.33f),
            new Employee(2, "sonali", 12.33f),
            new Employee(3, "manali", 1233f),
            };

            foreach (Employee emp in e)
            {
                Console.WriteLine(emp);
            }
        }
    }



    public class Product
    {
        int product_id;
        string name;
        double price;

        public Product(int product_id, string name, double price)
        {
            this.Product_id = product_id;
            this.Name = name;
            this.Price = price;
        }

        public int Product_id { get => product_id; set => product_id = value; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
    }

    class sell
    {
        static void Main(string[] args)
        {

            Product[] pList = new Product[]
            {
         new Product(1,"p1",12.33f),
         new Product(2,"p2",12.33f),
         new Product(3,"p3",12.33f),
            };

            foreach (Product p in pList)
            {
                Console.WriteLine($"ID : {p.Product_id} NAME :{p.Name} Price : {p.Price}");
            }
        }
    }

    //4 rows 3 cols using for display

    class Array2D
        {
        static void Main(string[] args)
        {
            int[,] a = new int[4, 3]
                {{0,0,2},{1,3,2},{4,3,5},{2,4,5 }};

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                    Console.Write(a[i, j] + " ");
                Console.WriteLine();
            }
            
            
             foreach(int item in a)
            {
                Console.WriteLine(item + " ");      
            }
        }

        }

    class jagged
    {
        static void Main(string[] args)
        {
            // int[][] ja = new int[4][];
            //  ja[0]= new int[2] {1,2};
            //  ja[1]=new int[3] {1,2,3};
            //  ja[2]=new int [1] {1};
            //  ja[4]=new int [4] {1,2,3,4};

            int[][] ja = new int[4][]
            {    new int[2] { 1, 2 },
                 new int[3] { 1, 2, 3 },
                 new int[1] { 1 },
                 new int[4] { 1, 2, 3, 4 } 
            };

            for(int i=0;i<ja.GetLength(0);i++)
            {
                for(int j=0;j<ja[i].Length;j++)
                {
                    Console.Write(ja[i][j] + " ");
                }
                Console.WriteLine();
            }

        }
    }


    class d1
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(411017, "Pune");
            d.Add(411018, "Mumbai");
            d.Add(411011, "ravet");
            d.Add(411012, "surat");
            /*
            foreach (KeyValuePair<int,string> kvp in d)
            {
                Console.WriteLine(kvp.Key + " " +kvp.Value);
            }*/
            foreach (var kvp in d)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }
        }
    }

    //generic class

    public class Test<T>
      {
            T element;

            public void Add(T element)
            {
                this.element = element;
            }
             

        public T Display()
            {
            return element;
            }  
      }
    public class Test<T1,T2>
    {
        T1 element1;
        T2 element2;
        public void Add(T1 element1,T2 element2)
        {
            this.element1 = element1;
            this.element2 = element2;
        }
        /*
        public T1 Display()
        {
            return element1;
        }
        public T2 Display1()
        {
            return element2;
        }
        */
        public T1 key { get => element1; set=> element1=value; }
        public T2 value { get => element2; set => element2=value; }

    }

    
    class gene
    {
        static void Swap<T>(ref T a, ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
           
        }
        static void Main(string[] args)
        {
            Test<int> obj1 = new Test<int>();
            obj1.Add(1);
            Console.WriteLine(obj1.Display());
            Test<string> obj2 = new Test<string>();
            obj2.Add("manali");
            Console.WriteLine(obj2.Display());

            /*
            Swap<int>(10, 20);
            Swap<string>("hello", "hi");
            Swap<double>(1.1, 2.2); 
            //need to display in method only
            */

            //using ref keyword
            int a = 12, b = 13;
            Swap<int>(ref a, ref b);
            Console.WriteLine($"a :{a}  b: {b}");
        }
    }

   class gene1
    {
        
        static void Main(string[] args)
        {
            Test<int, string> obj1 = new Test<int, string>();
            obj1.Add(1, "manali");
            Console.WriteLine(obj1.key+" "+obj1.value);
        }
    }

    class calc
    {
        static void Calculation(int a, int b, out int sum, out int subtract,out int multiply,out int division)
        {
            sum = a + b;
            subtract = a - b;
            multiply = a * b;
            division = a / b;
        }
        static void Main(string[] args)
        {   //variable w/o initializing value allowed when we use out keyword
            int a = 45, b = 23, sum,subtract, multiply,division;
            Calculation(a, b, out sum,out subtract, out multiply,out division);
            Console.WriteLine($"SUM :{sum}\nSUBTRACT : {subtract}\nMULTIPLY :{multiply}\nDIVISION :{division}");
        }
    }
}

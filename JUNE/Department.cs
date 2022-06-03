using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.JUNE
{
    class Department
    {
         int department_id;
         string department_name;
         string location;

        public Department()
        { }
        public Department(int department_id, string department_name, string location="surat")
        {  //this refer to data member
            this.department_id = department_id;
            this.department_name = department_name;
            this.location = location;
        }

        public int Department_id { get; set; }
        public string Department_name { get; set; }
        public string Location { get; set; }

        public override string ToString()
        {
            return $"ID :{Department_id} Department_name :{Department_name} Location :{Location}";
        }
    }
    class Test
    {
        static void Main(string[] args)
        { //property initializer
            Department d1 = new Department();
            d1.Department_id = 1;
            d1.Department_name = "sales";
            d1.Location = "pune";

            //object initializer
            Department d2 = new Department { Department_id = 2, Department_name = "sales", Location = "pune" };
            Console.WriteLine(d1 +" \n"+d2);

            Department d3 = new Department(1,"HR","mumbai");
            //named arguments
            Department d4 = new Department(department_name : "HR",department_id:4,location :  "mumbai");
            //optional parameter
            Department d5 = new Department(5, "HR");

        }
    }


}

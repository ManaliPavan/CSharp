using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.April1.OOPS
{
    class DataCar
    {
        class car
        {
           public int carId;
           public String model;
           public String color;
           public String brand;
           public String purchDate;

    public void display()
            {
                Console.WriteLine("Car");
            }
            
        }

        static void Main(string[] args)
        {
           
            car c1 = new car();
            car c2 = new car();
            
            Console.WriteLine("Enter car details:(carId,model,color,brand,purchDate) ");
            c1.carId = Convert.ToInt32(Console.ReadLine());
            c1.model = Console.ReadLine();
            c1.color = Console.ReadLine();
            c1.brand= Console.ReadLine();
            c1.model = Console.ReadLine();
            c1.purchDate = Console.ReadLine();
            Console.WriteLine("Enter car details:(carId,model,color,brand,purchDate) ");
            c2.carId = Convert.ToInt32(Console.ReadLine());
            c2.model = Console.ReadLine();
            c2.color = Console.ReadLine();
            c2.brand = Console.ReadLine();
            c2.model = Console.ReadLine();
            c2.purchDate = Console.ReadLine();
            Console.WriteLine("you have entered details for \n"+c1.model+" \n "+c2);
            Console.WriteLine("Car Details");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.Mar31
{
    class Print3D
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter dimentions");
            Console.WriteLine("row size");
            int sizer = int.Parse(Console.ReadLine());
            Console.WriteLine("column size");
            int sizec = int.Parse(Console.ReadLine());
            Console.WriteLine("column size");
            int sizea = int.Parse(Console.ReadLine());

            int[,,] a3 = new int[sizer, sizec,sizea];
            for (int r = 0; r < a3.GetLength(0); r++)
            {

                for (int c = 0; c < a3.GetLength(1); c++)
                {
                    Console.WriteLine("Enter row elements of row " + r);
                    for (int a = 0; a < a3.GetLength(2); a++)
                    {
                        a3[r, c, a] = int.Parse(Console.ReadLine());
                    }
                }
            }
            for (int r = 0; r < a3.GetLength(0); r++)
            {
                for (int c = 0; c < a3.GetLength(1); c++)
                {
                    for (int a = 0; a < a3.GetLength(2); a++)
                    {

                        Console.Write(a3[r, c, a] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

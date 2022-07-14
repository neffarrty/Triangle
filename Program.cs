using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the 1 side of triangle: ");
            var sideA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the length of the 2 side of triangle: ");
            var sideB = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the length of the 3 side of triangle: ");
            var sideC = Convert.ToInt32(Console.ReadLine());


            if (sideA + sideB < sideC || sideB + sideC < sideA || sideA + sideC < sideB)
            {
                Console.WriteLine("Error. Length of the one side of triangle cannot be bigger than sum of the other two");
            }
            else
            {
                float perimeter = sideA + sideB + sideC;
                float semiPerimeter = perimeter / 2;

                double triangleArea = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));

                Console.WriteLine("Counted!");
                Console.WriteLine($"Triangle perimeter = {perimeter}, triangle area = {triangleArea}");
                
            }

            Console.ReadKey();

        }
    }
}

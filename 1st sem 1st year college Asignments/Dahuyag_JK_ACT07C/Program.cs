using System;

namespace Dahuyag_JK_ACT07C
{
    class Program
    {
        static void Main(string[] args)
        {
            double leg1, leg2, hypothenuse, radical;
            Console.WriteLine("Enter the dimensions of the legs of the right triangle: ");
            leg1 = Convert.ToDouble(Console.ReadLine());
            leg2 = Convert.ToDouble(Console.ReadLine());
            radical = Math.Pow(leg1, 2) + Math.Pow(leg2, 2);
            hypothenuse = Math.Sqrt(radical);
            Console.WriteLine("sqrt({0}^2 + {1}^2) = {2}", leg1,leg2,hypothenuse);
            Console.WriteLine("The hypothenuse of the right triangle is {0}",hypothenuse);
            Console.ReadLine();
        }
    }
}

using System;

namespace Dahuyag_JK_ACT07A
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Enter two (2) values:");
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Here are the outputs from all given Math methods using the two entered values: ");
            Console.WriteLine(Math.E);
            Console.WriteLine(Math.PI);
            Console.WriteLine(Math.Abs(x));
            Console.WriteLine(Math.Ceiling(y));
            Console.WriteLine(Math.Cos(x));
            Console.WriteLine(Math.Exp(y));
            Console.WriteLine(Math.Floor(x));
            Console.WriteLine(Math.Log(y));
            Console.WriteLine(Math.Log10(x));
            Console.WriteLine(Math.Max(x, y)); 
            Console.WriteLine(Math.Min(x, y));
            Console.WriteLine(Math.Pow(x, y));
            Console.WriteLine(Math.Round(y));
            Console.WriteLine(Math.Sign(x));
            Console.WriteLine(Math.Sin(y));
            Console.WriteLine(Math.Sqrt(x));
            Console.WriteLine(Math.Tan(y));
            Console.WriteLine(Math.Truncate(x));
            Console.WriteLine(Math.Acos(y));
            Console.WriteLine(Math.Asin(x));
            Console.WriteLine(Math.Atan(y));

            Console.ReadLine();
        }
    }
}

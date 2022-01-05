using System;

namespace Dahuyag_JK_ACT06F
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            Console.WriteLine("x\tx^2\t(x^3)+9\t(x^4)/3");
            while (x < 100)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", x, x * x, x * x * x + 9, (x * x * x * x) / 3);//outputs the value for each column
                x++;
            }
            Console.ReadLine();
        }
    }
}

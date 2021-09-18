using System;

namespace Dahuyag_JK_ACT05A
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = -10000;

            if (num1 < 5)
            {
                Console.WriteLine("III");
                Console.WriteLine("Ready...");
            }
            else if (num1 == 5)
            {
                Console.WriteLine("II");
                Console.WriteLine("Get Set...");
            }
            else if (num1 > 5)
            {
                Console.WriteLine("I");
                Console.WriteLine("Go!");
            }
            else
                Console.WriteLine("NOTHING");

            Console.ReadLine();
        }
    }
}

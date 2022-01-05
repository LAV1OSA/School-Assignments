using System;

namespace Dahuyag_JK_ACT05B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 18)
            {
                Console.WriteLine("{0}: \" You are a minor! \"", name);
            }
            else // I only put else since every other input will already be 18 and above
            {
                Console.WriteLine("{0}: \" You are of legal age \"", name);
            }

            Console.ReadLine();
        }
    }
}

using System;

namespace Dahuyag_JK_ACT04C
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int firstNumber = Convert.ToInt32(input);
            int secondNumber = 1000;

            int result = firstNumber + secondNumber;

            Console.WriteLine("Result: {0}", result);
            Console.ReadLine();
        }
    }
}

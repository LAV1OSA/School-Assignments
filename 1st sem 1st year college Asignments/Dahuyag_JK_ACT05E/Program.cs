using System;

namespace Dahuyag_JK_ACT05E
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, quotient, remainder;
            double num2Half;
            Console.WriteLine("Please input 2 integer numbers:");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            quotient = num1 / num2;
            remainder = num1 % num2;
            Console.WriteLine("\nWhen dividing {2} by {3};\nThe whole number part of the quotient will be: {0}\nThe remainder will be: {1}\n",quotient,remainder,num1,num2);
            num2Half = Convert.ToDouble(num2) / 2f;


            if (remainder == num2Half)
            {
                Console.WriteLine("{0} is half of {1}", remainder, num2);
            }
            else if (remainder > num2Half)
            {
                Console.WriteLine("{0} is greater than half of {1}", remainder, num2);
            }
            else if (remainder < num2Half)
            {
                Console.WriteLine("{0} is less than half of {1}", remainder, num2);
            }
            else
                Console.WriteLine("Error");
            Console.ReadLine();
        }
    }
}

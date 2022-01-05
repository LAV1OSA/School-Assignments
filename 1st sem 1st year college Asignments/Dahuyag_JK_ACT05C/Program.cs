using System;

namespace Dahuyag_JK_ACT05C
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.WriteLine("Please input 3 integers: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nResults:\n");

            if ((num1 > num2) && (num2 > num3)) //this condition is where num2 will be the middle value
            {
                Console.WriteLine("{0} is the lowest value entered\n{1} is the middle value entered\n{2} is the highest value entered", num3, num2, num1);
            }
            else if ((num1 < num2) && (num2 < num3)) //this condition is where num2 will be the middle value
            {
                Console.WriteLine("{0} is the lowest value entered\n{1} is the middle value entered\n{2} is the highest value entered", num1, num2, num3);
            }
            else if ((num2 > num1) && (num1 > num3)) //this condition is where num1 will be the middle value
            {
                Console.WriteLine("{0} is the lowest value entered\n{1} is the middle value entered\n{2} is the highest value entered", num3, num1, num2);
            }
            else if ((num2 < num1) && (num1 < num3)) //this condition is where num1 will be the middle value
            {
                Console.WriteLine("{0} is the lowest value entered\n{1} is the middle value entered\n{2} is the highest value entered", num2, num1, num3);
            }
            else if ((num1 > num3) && (num3 > num2)) //this condition is where num3 will be the middle value
            {
                Console.WriteLine("{0} is the lowest value entered\n{1} is the middle value entered\n{2} is the highest value entered", num2, num3, num1);
            }
            else if ((num1 < num3) && (num3 < num2)) //this condition is where num3 will be the middle value
            {
                Console.WriteLine("{0} is the lowest value entered\n{1} is the middle value entered\n{2} is the highest value entered", num1, num3, num2);
            }
            else
                Console.WriteLine("Error! You entered atleast 2 integers with equal value");

            Console.ReadLine();
        }
    }
}

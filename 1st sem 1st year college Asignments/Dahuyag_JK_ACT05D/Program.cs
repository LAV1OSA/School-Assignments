using System;

namespace Dahuyag_JK_ACT05D
{
    class Program
    {
        static void Main(string[] args)
        {
            int operation;
            double result1, result2, firstnumber, secondnumber;

            Console.WriteLine("Please enter your first integer number:");
            firstnumber = Convert.ToDouble(Console.ReadLine()); //converted to double so division will include decimals
            Console.WriteLine("Please enter your second integer number:");
            secondnumber = Convert.ToDouble(Console.ReadLine()); //converted to double so division will include decimals
            Console.WriteLine("What is your desired operation?\n1 - Addition\n2 - Subtraction\n3 - Multiplication\n4 - Division\n5 - Modulus\nEnter the number of the desired operation:");
            operation = Convert.ToInt32(Console.ReadLine());

            if (operation == 1)//Addition
            {
                Console.WriteLine("\nAddition:");
                result1 = firstnumber + secondnumber;
                Console.WriteLine("{0} + {1} = {2}", firstnumber, secondnumber, result1.ToString("F"));
            }
            else if (operation == 2)//Subtraction
            {
                Console.WriteLine("\nSubtraction:");
                result1 = firstnumber - secondnumber;
                result2 = secondnumber - firstnumber;
                Console.WriteLine("{0} - {1} = {2} \n{1} - {0} = {3} ", firstnumber, secondnumber, result1.ToString("F"), result2.ToString("F"));
            }
            else if (operation == 3)//Multiplication
            {
                Console.WriteLine("\nMultiplication:");
                result1 = firstnumber * secondnumber;
                Console.WriteLine("{0} * {1} = {2}", firstnumber, secondnumber, result1.ToString("F"));

            }
            else if (operation == 4)//Division
            {
                Console.WriteLine("\nDivision:");
                result1 = firstnumber / secondnumber;
                result2 = secondnumber / firstnumber;
                Console.WriteLine("{0} / {1} = {2} \n{1} / {0} = {3} ", firstnumber, secondnumber, result1.ToString("F"), result2.ToString("F"));
            }
            else if (operation == 5)//Modulus
            {
                Console.WriteLine("\nModulus:");
                result1 = firstnumber % secondnumber;
                result2 = secondnumber % firstnumber;
                Console.WriteLine("{0} % {1} = {2} \n{1} % {0} = {3} ", firstnumber, secondnumber, result1.ToString("F"), result2.ToString("F"));
            }
            else
                Console.WriteLine("Your input was invalid");
            Console.ReadLine();
        }
    }
}

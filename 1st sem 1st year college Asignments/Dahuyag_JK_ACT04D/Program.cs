using System;

namespace Dahuyag_JK_ACT04D
{
    class Program
    {
        static void Main(string[] args)
        {
            //here, the program will ask for 2 integers
            Console.WriteLine("Enter your first integer number: ");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter your second integer number: ");
            string input2 = Console.ReadLine();

            //here, the program will convert the inputs into integer data type
            int firstnumber = Convert.ToInt32(input1);
            int secondnumber = Convert.ToInt32(input2);

            //Addition
            Console.WriteLine("\nAddition:");
            int addedNum = firstnumber + secondnumber;
            Console.WriteLine("{0} + {1} = {2}",firstnumber, secondnumber, addedNum);

            //Subtraction
            Console.WriteLine("\nSubtraction:");
            int subtractedNum1 = firstnumber - secondnumber;
            int subtractedNum2 = secondnumber - firstnumber;
            Console.WriteLine("{0} - {1} = {2} \n{1} - {0} = {3} ", firstnumber, secondnumber, subtractedNum1, subtractedNum2);

            //Multiplication
            Console.WriteLine("\nMultiplication:");
            int multipliedNum1 = firstnumber * secondnumber;
            Console.WriteLine("{0} * {1} = {2}",firstnumber, secondnumber, multipliedNum1);

            //Division
            Console.WriteLine("\nDivision:");
            int dividedNum1 = firstnumber / secondnumber;
            int dividedNum2 = secondnumber / firstnumber;
            Console.WriteLine("{0} / {1} = {2} \n{1} / {0} = {3} ", firstnumber, secondnumber, dividedNum1, dividedNum2);

            //Modulus
            Console.WriteLine("\nModulus:");
            int modedNum1 = firstnumber % secondnumber;
            int modedNum2 = secondnumber % firstnumber;
            Console.WriteLine("{0} % {1} = {2} \n{1} % {0} = {3} ", firstnumber, secondnumber, modedNum1, modedNum2);

            Console.WriteLine("\nAnd that is addition, subtraction, multiplication, division and modulus applied to the numbers " + firstnumber + " and " + secondnumber + "!");
        }
    }
}

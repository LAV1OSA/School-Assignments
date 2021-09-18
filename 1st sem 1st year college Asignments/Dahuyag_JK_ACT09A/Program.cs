using System;

namespace Dahuyag_JK_ACT09A
{
    class Program
    {
        static void Main(string[] args)
        {
            double fnum, snum, output;
            fnum = GetFirstNumber();
            snum = GetSecondNumber();
            output = AddNumbers(fnum, snum);
            printResult(output);
            Console.ReadLine();
        }
        static double GetFirstNumber()
        {
            Console.WriteLine("First Number: ");
            string firstNumberInput = Console.ReadLine();
            double firstNumber = Convert.ToDouble(firstNumberInput);
            return firstNumber;
        }
        static double GetSecondNumber()
        {
            Console.WriteLine("Second Number: ");
            string secondNumberInput = Console.ReadLine();
            double secondNumber = Convert.ToDouble(secondNumberInput);
            return secondNumber;
        }
        static double AddNumbers(double firstNumber, double secondNumber)
        {
            double sum;
            sum = firstNumber + secondNumber;
            return sum;
        }
        static void printResult(double result)
        {
            Console.WriteLine(result);
        }
    }
}

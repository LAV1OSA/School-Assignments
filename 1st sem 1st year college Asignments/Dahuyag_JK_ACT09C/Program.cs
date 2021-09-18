using System;

namespace Dahuyag_JK_ACT09C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer: ");
            int num = Convert.ToInt32(Console.ReadLine());
            printResult(num);
            Console.ReadLine();
        }
        static double squaredNum(int baseNum)
        {
            int square = baseNum * baseNum;
            return square;
        }
        static double cubedNum(int baseNum)
        {
            int cube = baseNum * baseNum * baseNum;
            return cube;
        }
        static double squareRoot(double baseNum, float errorlevel)
        {
            double rootApprox = baseNum;
            double root;
            while (true) //This is a code based on Newton's method in finding roots
            {
                // Calculate closer approximate root
                root = 0.5 * (rootApprox + (baseNum / rootApprox));
                // Check for error
                if (Math.Abs(root - rootApprox) < errorlevel)
                    break;
                // Update root
                rootApprox = root;
            }
            return root;
        }
        static double cubeRoot(double baseNum, float errorlevel)
        {
            double rootApprox = baseNum;
            double root;
            while (true)//I modified the square root code and got this formula that still follows Newton's method of finding roots
            {
                // Calculate closer approximate root
                root = 0.5 * (rootApprox + (baseNum / (rootApprox*rootApprox)));
                // Check for error
                if (Math.Abs(root - rootApprox) < errorlevel)
                    break;
                // Update root
                rootApprox = root;
            }
            return root;
        }
        static void printResult(int num)
        {
            double squared, cubed, rootSquare = 0, rootCube;
            float errorlevel = 0.000001f;
            squared = squaredNum(num);
            cubed = cubedNum(num);
            if(num > 0)
                rootSquare = squareRoot(num,errorlevel);
            rootCube = cubeRoot(num, errorlevel);
            if (num > 0)
                Console.WriteLine("The number entered is: {0}\nThe square of the number is: {1}\nThe cube of the number is: {2}\nThe square root of the number is: {3:F5}\nThe cube root of the number is: {4:F5}\n", num, squared, cubed, rootSquare, rootCube);
            else
                Console.WriteLine("The number entered is: {0}\nThe square of the number is: {1}\nThe cube of the number is: {2}\nThe square root of the number is imaginary\nThe cube root of the number is: {3:F5}\n", num, squared, cubed, rootCube);
        }
    }
}

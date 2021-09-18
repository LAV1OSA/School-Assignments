using System;

namespace Dahuyag_JK_ACT08B
{
    class Program
    {
        static void Main(string[] args)
        {
            int gradesSum;
            double gradesAve;
            gradesSum = 0;
            Console.WriteLine("Please enter 5 grades:");
            int[] grades = new int[5];
            for (int x = 0; x< 5; x++)
            {
                grades[x] = Convert.ToInt32(Console.ReadLine());
            }
            for (int y = 0; y < 5; y++)
            {
                gradesSum += grades[y];
            }
            gradesAve = Convert.ToDouble(gradesSum) / 5f;

            Console.WriteLine("Sum: {0} \nAverage: {1}\nEntered Grades:", gradesSum, gradesAve.ToString("F"));
            for(int z = 0; z < 5; z++)
            {
                Console.WriteLine(grades[z]);
            }
            Console.ReadLine();
        }
    }
}

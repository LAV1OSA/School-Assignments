using System;

namespace Dahuyag_JK_ACT06E
{
    class Program
    {
        static void Main(string[] args)
        {
            int input, total, x;
            double average;
            total = 0;
            Console.WriteLine("input TEN (10) integer numbers:");
            for(x = 0; x < 10; x++)
            {
                input = Convert.ToInt32(Console.ReadLine());//asks for input for every instance in the loop
                total += input;//each input is added to the total
            }
            average = Convert.ToDouble(total) / Convert.ToDouble(x);
            Console.WriteLine("The sum of the numbers entered is: {0}\nThe average of the numbers entered is: {1}", total, average);
            Console.ReadLine();
        }
    }
}

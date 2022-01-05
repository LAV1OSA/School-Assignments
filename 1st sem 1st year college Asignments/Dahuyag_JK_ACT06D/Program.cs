using System;

namespace Dahuyag_JK_ACT06D
{
    class Program
    {
        static void Main(string[] args)
        {
            int input,total,x;
            double average;
            x = 0;
            total = 0;
            Console.WriteLine("input TEN integer numbers:");
            do
            {
                input = Convert.ToInt32(Console.ReadLine());//asks for input for every instance in the loop
                total += input;//input is added to the total
                x++;
            } while (x < 10);
            average = Convert.ToDouble(total) / Convert.ToDouble(x);
            Console.WriteLine("The sum of the numbers entered is: {0}\nThe average of the numbers entered is: {1}", total, average);
            Console.ReadLine();
        }
    }
}

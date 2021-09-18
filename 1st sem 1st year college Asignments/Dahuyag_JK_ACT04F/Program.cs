using System;

namespace Dahuyag_JK_ACT04F
{
    class Program
    {
        static void Main(string[] args)
        {
            //setting the variables
            int a = 2;
            int b = 5;
            int c = -3;

            // solving each fraction of the expression
            double result1 = Math.Pow(a, 2) * Math.Pow(b, 3) * c;
            double result2 = Math.Pow(a, 4) * Math.Pow(b, 2) * Math.Pow(c, 2) / 7;
            double result3 = 3 * Math.Pow(b, 3) * Math.Pow(c, 2);
            double result4 = 2 * Math.Pow(b, -2) * Math.Pow(c, -3) * Math.Pow(a, -3);

            // combining all parts
            double finalResult = result1 + result2 - result3 + result4;
            // displaying the final answer
            Console.WriteLine(finalResult);
        }
    }
}

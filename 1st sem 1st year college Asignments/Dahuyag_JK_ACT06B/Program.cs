using System;

namespace Dahuyag_JK_ACT06B
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            string firstRow, secondRow;
            x = 0;
            firstRow = Convert.ToString(x + 1);
            secondRow = Convert.ToString(x);
            while (x < 19)
            {
                x += 2;
                secondRow = secondRow + " " + Convert.ToString(x);//adding the new x into the string
                x++;
                firstRow = firstRow + " " + Convert.ToString(x);//adding the new x into the string
                x--;
            }
            Console.WriteLine("{0}\n{1}",firstRow,secondRow);
            Console.ReadLine();
        }
    }
}

using System;

namespace Dahuyag_JK_ACT06C
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            string firstRow, secondRow;
            firstRow = "";
            secondRow = "";
            for (x = 0; x <21; x += 2)
            {
                secondRow = secondRow + " " + Convert.ToString(x); //adding the new x into the string
                x++;
                firstRow = firstRow + " " + Convert.ToString(x);//adding the new x into the string
                x--;
            }
            Console.WriteLine("{0}\n{1}", firstRow, secondRow);
            Console.ReadLine();
        }
    }
}

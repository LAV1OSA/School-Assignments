using System;

namespace Dahuyag_JK_ACT08E
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] titletabs = new int[10]
            { 1, 2,3, 4, 5, 6, 7, 8, 9,10};
            int x, y;
            int result;
            Console.WriteLine("This is the Multiplication Table:\n\n");
            Console.Write("\t");

            for (x = 0; x < 10; x++) //for the top row
            {
                Console.Write("  {0}\t", titletabs[x]);
                if (x == 9)
                {
                    Console.WriteLine();
                    for (x = 0; x < 12; x++)
                    {
                        Console.Write("-------");
                    }
                    Console.WriteLine();
                }
            }
            for (y = 0; y < 10; y++)// for the content
            {
                if (y < 9)
                    Console.Write(" {0}|", titletabs[y]);
                else
                    Console.Write("{0}|", titletabs[y]);
                for (x = 0; x < 10; x++)
                {
                    result = titletabs[y] * titletabs[x];

                    if (result == 100) //the spaces are for uniformity
                        Console.Write("\t" + " {0}", result);
                    else if (x == 9)
                        Console.Write("\t  {0}", result);
                    else if (result < 10)
                        Console.Write("\t  {0}", result);
                    else if (result >= 10 && result < 100)
                        Console.Write("\t {0}", result);
                }
                Console.WriteLine();
            }
          
            Console.ReadLine();
        }
    }
}

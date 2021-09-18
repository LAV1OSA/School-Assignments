using System;

namespace Dahuyag_JK_ACT08C
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] titletabs = new int[10]
            { 1, 2,3, 4, 5, 6, 7, 8, 9,10};
            int x = 0;
            int y = 0;
            int result;
            Console.WriteLine("This is the Multiplication Table:\n\n");
            Console.Write("\t");
            while (x < 10)
            {
                Console.Write("  {0}\t",titletabs[x]);
                x++;
                if (x == 10)
                {
                    x = 0;
                    Console.WriteLine();
                    while (x < 12) 
                    {
                        Console.Write("-------");
                        x++;
                    }
                }
            }
            Console.WriteLine();
            x = 0;
            while (y < 10)
            {
                if (y < 9)
                    Console.Write(" {0}|", titletabs[y]);
                else
                    Console.Write("{0}|", titletabs[y]);
                while (x < 10)
                {
                    result = titletabs[y] * titletabs[x];

                    if (result == 100)
                        Console.Write("\t" + " {0}", result);
                    else if (x == 9)
                        Console.Write("\t  {0}", result);
                    else if (result < 10)
                        Console.Write("\t  {0}", result);
                    else if (result >= 10 && result < 100)
                        Console.Write("\t {0}", result);

                    x++;
                    if (x == 10)
                        Console.WriteLine();
                }
                y++;
                x = 0;
            }

            
            Console.ReadLine();
        }
    }
}

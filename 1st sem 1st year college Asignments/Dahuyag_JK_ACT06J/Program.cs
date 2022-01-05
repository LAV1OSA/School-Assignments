using System;

namespace Dahuyag_JK_ACT06J
{
    class Program
    {
        static void Main(string[] args)
        {
            int y;
            y = 0;
            for (int x = 100; x > 99 && x < 501; x++)
            {
                if ((x % 5 == 0) && (x % 6 == 0))
                {
                    continue;
                }
                else if ((x % 5 == 0) || (x % 6 == 0))
                {
                    Console.Write(x + "\t");
                    y++;
                }

                if (y == 10)
                {
                    Console.WriteLine();
                    y = 0;
                }
            }
            Console.ReadLine();
        }
    }
}

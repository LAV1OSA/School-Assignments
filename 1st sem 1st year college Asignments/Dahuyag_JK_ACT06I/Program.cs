using System;

namespace Dahuyag_JK_ACT06I
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            x = 100;
            y = 0;
            do
            {
                do // Counts how many values there are in the line
                {
                    if ((x % 5 == 0) && (x % 6 == 0))
                    {
                        x++;
                    }
                    else if ((x % 5 == 0) || (x % 6 == 0))
                    {
                        Console.Write(x + "\t");
                        x++;
                        y++;
                    }
                    else if (x >= 501)
                    {
                        break;
                    }
                    else
                    {
                        x++;
                    }
                } while (y < 10);
                Console.WriteLine();
                y = 0;
            } while ((x > 99) && (x < 501)); // Checks if the value is at least 100 and at most 500

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

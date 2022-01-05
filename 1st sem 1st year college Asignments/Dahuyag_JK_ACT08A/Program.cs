using System;

namespace Dahuyag_JK_ACT08A
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            int[] number = new int[10];
            for (int i = 0; i < 10; i++)
            {
                x = i + 1;
                number[i] = x;
            }
            for (int j = 0; j < 10; j++)
            {
                y = number[j];
                Console.WriteLine("Element[{0}] = {1}", j, y);
            }
            Console.ReadLine();
        }
    }
}

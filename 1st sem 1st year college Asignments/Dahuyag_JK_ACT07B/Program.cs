using System;

namespace Dahuyag_JK_ACT07B
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, largestNum, middleNum, smallestNum;
            Console.WriteLine("Please enter three (3) integer values:");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            z = Convert.ToInt32(Console.ReadLine());

            largestNum = Math.Max(Math.Max(x, y), z);
            smallestNum = Math.Min(Math.Min(x, y), z);
            if (x != largestNum && x != smallestNum)
            {
                middleNum = x;
            }
            else if (y != largestNum && y != smallestNum)
            {
                middleNum = y;
            }
            else
            {
                middleNum = z;
            }


            Console.WriteLine("{0} {1} {2}", largestNum,middleNum,smallestNum);
            Console.ReadLine();
        }
    }
}

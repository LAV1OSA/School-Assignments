using System;

namespace Dahuyag_JK_ACT09B
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 0;
            int z = 0;
            int[] evenNum = new int[50];
            int[] oddNum = new int[50];
           
            Console.WriteLine("Here is the list of even numbers:");
            for (y = 0; y < 50; y++)
            {
                if (y == 49)
                {
                    Console.Write("{0} ", evenNum[y]);
                    break;
                }
                Console.Write("{0}, ",evenNum[y]);
            }
            Console.WriteLine("\nHere is the list of odd numbers:");
            for (y = 0; y < 50; y++)
            {
                if (y == 49)
                {
                    Console.Write("{0} ", oddNum[y]);
                    break;
                }
                Console.Write("{0}, ", oddNum[y]);
            }
            Console.ReadLine();
        }
        static int evenNum(int num)
        {
            int[] evenNum = new int[50];

           /* if (num % 2 == 0)
                return true;
            else
                return false;
            for (int x = 1; x < 101; x++)
            {
                if (isEven(x))
                {
                    evenNum[y] = x;
                    y++;
                }
                else
                {
                    oddNum[z] = x;
                    z++;
                }
            }*/
        }
        /*static void Main(string[] args)
        {
            int y = 0;
            int z = 0;
            int[] evenNum = new int[50];
            int[] oddNum = new int[50];
            for (int x = 1; x < 101; x++)
            {
                if (isEven(x))
                {
                    evenNum[y] = x;
                    y++;
                }
                else
                {
                    oddNum[z] = x;
                    z++;
                }
            }
            Console.WriteLine("Here is the list of even numbers:");
            for (y = 0; y < 50; y++)
            {
                if (y == 49)
                {
                    Console.Write("{0} ", evenNum[y]);
                    break;
                }
                Console.Write("{0}, ", evenNum[y]);
            }
            Console.WriteLine("\nHere is the list of odd numbers:");
            for (y = 0; y < 50; y++)
            {
                if (y == 49)
                {
                    Console.Write("{0} ", oddNum[y]);
                    break;
                }
                Console.Write("{0}, ", oddNum[y]);
            }
            Console.ReadLine();
        }
        static bool isEven(int num)
        {
            if (num % 2 == 0)
                return true;
            else
                return false;
        }*/
    }
}

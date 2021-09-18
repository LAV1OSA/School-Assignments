using System;

namespace Dahuyag_JK_ACT09B
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberList = new int[100];
            int[] oddNumbers = new int[50];
            int[] evenNumbers = new int[50];
            for (int x = 0; x < 100; x++)
            {
                numberList[x] = x + 1;
            }
            EvenNum(numberList).CopyTo(evenNumbers,0);
            OddNum(numberList).CopyTo(oddNumbers,0);

            Console.WriteLine("Here is the list of odd and even numbers:\nOdd:\tEven:");
            for(int index = 0; index < 50; index++)
            {
                Console.Write("{1}\t{0}", evenNumbers[index], oddNumbers[index]);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        static Array EvenNum(Array numbers)
        {
            int[] listOFEvenNumbers = new int[50];
            int index = 0;
            foreach (int x in numbers) 
            {
                if (x % 2 == 0)
                {
                    listOFEvenNumbers[index] = x;
                    index++;
                }
                   
            }
            return listOFEvenNumbers;
        }
        static Array OddNum(Array numbers)
        {
            int[] listOfOddNumbers = new int[50];
            int index = 0;
            foreach (int x in numbers)
            {
                if (x % 2 != 0)
                {
                    listOfOddNumbers[index] = x;
                    index++;
                }

            }
            return listOfOddNumbers;
        }
    }
}

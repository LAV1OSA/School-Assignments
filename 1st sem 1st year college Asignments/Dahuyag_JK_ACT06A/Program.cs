using System;

namespace Dahuyag_JK_ACT06A
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int w = 1; w < 3; w++)
            {
                Console.WriteLine(w);
                //You can add statements here
                Console.WriteLine("is still less than 3");
            }
            Console.WriteLine(" ");

            int x = 1;
            while (x < 3)
            {
                Console.WriteLine(x);
                x = x + 1;
                //You can add statements here
                Console.WriteLine("I am still in this while loop!");
            }
            Console.WriteLine(" ");

            x = 1;
            do
            {
                Console.WriteLine(x);
                x = x + 1;
                //You can add statements here
                Console.WriteLine("This will only break if it reaches to 3!!");
            } while (x < 3);

            Console.ReadLine();
        }
    }
}

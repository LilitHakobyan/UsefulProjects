using System;

namespace TaskA
{
    class Program
    {
        public static void DivFT(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            DivFT(n);
            Console.ReadKey();

        }
    }
}

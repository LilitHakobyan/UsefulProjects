using System;


namespace TaskB
{
    class Program
    {
        public static int NumbOfCircl(int n)
        {
            int m;
            int k = 0;
           
            while (n != 0)
            {
                m = n % 10;
                if ((m == 0) || (m == 4) || (m == 6) || (m == 9))
                {
                    k++;
                }
                else if (m == 8)
                {
                    k += 2;
                }
                n = n / 10;
            }
            return k;

        }
        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(NumbOfCircl(n));
            Console.ReadKey();

        }
    }
}

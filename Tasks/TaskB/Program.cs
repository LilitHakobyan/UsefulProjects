using System;


namespace TaskB
{
    class Program
    {
        static void Main(string[] args)
        {
            int m=0;
            int k=0; 
          int n = Convert.ToInt32(Console.ReadLine());
            while (n!=0)
            {
                m = n%10;
                if ((m==0)|| (m == 4) || (m == 6) || (m == 9))
                {
                    k++;
                }
                else if (m==8)
                {
                    k += 2;
                }
                n = n/10;
            }
            Console.WriteLine(k);
            Console.ReadKey();

        }
    }
}

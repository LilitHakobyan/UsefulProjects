using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskA
{
    class Program
    {
        public static void DivFT(int a)
        {
            if ((a % 5 == 0) && (a % 3 == 0))
            {
                Console.WriteLine("Fizz Buzz");
            }
            else if (a % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (a % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
        }
        static void Main(string[] args)
        {
        }
    }
}

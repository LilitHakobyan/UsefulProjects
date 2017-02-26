using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polidrom
{
    class Program
    {
        public static bool isPoli(string str)
        {
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - i - 1])
                {
                    
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            bool value=isPoli(str);
            Console.WriteLine(value);
            Console.ReadKey();
        }
    }
}

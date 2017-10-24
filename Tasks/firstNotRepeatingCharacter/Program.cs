using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstNotRepeatingCharacter
{
    class Program
    {
        public static char FirstNotRepeatingCharacter(string s)
        {
            if (s.Length == 1)
                return Convert.ToChar(s);
            for (int i = 0; i < s.Length - 1; i++)
            {
                var elem = s.Substring(i, 1);
                var sbs1 = s.Substring(0, i);
                var sbs2 = s.Substring(i + 1);
                if (!sbs1.Contains(elem) && !sbs2.Contains(elem))
                    return Convert.ToChar(elem);
            }
            return '_';
        }
        static void Main(string[] args)
        {
            string s = "abacabad";
            Console.WriteLine(FirstNotRepeatingCharacter(s));
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override
{
    class Program
    {
        public static bool inCompare(int a, int b)
        {
            if (a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool inCompare(string a, string b)
        {
            if (a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool inCompare(int[] a, int[] b)
        {
            bool result = false;
            if (a.Length == b.Length)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == b[i])
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
            }
            return result;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Compeare function  for int {0}", inCompare(10, 15));
            Console.WriteLine("Compeare function  for string {0}", inCompare("ready", "ready"));
            int[] arr1 = { 1, 2, 3, 4, 5, 6 };
            int[] arr2 = { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine("Compeare function  for int array {0}", inCompare(arr1, arr2));
            Console.ReadKey();
        }
    }
}

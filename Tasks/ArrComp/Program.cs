using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrComp
{
    class Program
    {
        public static bool Contains(int[] arr, int item)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]==item)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool Compare(int[] a, int[] b)
        {
            if (a.Length == b.Length)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (Contains(b, a[i]))
                    {
                        continue;
                    }
                    else { return false;}
                }
            }
            else
            {
                return false;
            }
            return true;

        }
        static void Main(string[] args)
        {
            int[] arr1 = {1, 2, 3, 5, 8};
            int[] arr2 = {2, 1, 5, 8, 7};
            Console.WriteLine(Compare(arr1,arr2));
            Console.ReadKey();
        }
    }
}

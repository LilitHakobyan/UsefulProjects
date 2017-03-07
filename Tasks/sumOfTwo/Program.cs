using System;
using System.Collections.Generic;

namespace sumOfTwo
{
    class Program
    {
      public static  bool sumOfTwo(int[] a, int[] b, int v)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] + b[j] == v)
                        return true;
                }
            }
            return false;
        }
        //good practice
        static bool sumOfTwo1(int[] a, int[] b, int v)
        {
            var set = new HashSet<int>(b);

            foreach (var x in a)
            {
                var diff = v - x;
                if (set.Contains(diff)) return true;
            }
            return false;
        }


        static void Main(string[] args)
        {
            int[] a = {1, 2, 3};
            int[] b = {10, 20, 30, 40};
            sumOfTwo(a, b, 42);
            sumOfTwo1(a, b, 45);

        }
    }
    }


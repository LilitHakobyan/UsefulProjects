using System;

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

        static void Main(string[] args)
        {
            int[] a = {1, 2, 3};
            int[] b = {10, 20, 30, 40};
            sumOfTwo(a, b, 42);

        }
    }
    }


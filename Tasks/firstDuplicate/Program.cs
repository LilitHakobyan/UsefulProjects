using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace firstDuplicate
{
    class Program
    { public static int firstDuplicatebyStack(int[] a)
        {
            var stack = new Stack<int>();
            for (int i = 0; i < a.Length; i++)
            {
                if (stack.Contains(a[i]))
                    return a[i]; 
                stack.Push(a[i]);
            }
            return -1;
        }

        public static int FirstDuplicatebyDictionary(int[] a)// faster than firstDuplicatebyStack
        {
            var dictionary = new Dictionary<int,int>();
            foreach (var t in a)
            {
                try
                {
                    dictionary.Add(t, t);

                }
                catch 
                {
                    return t;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] a = {2, 3, 3, 4, 5, 6, 2};
             Console.WriteLine(firstDuplicatebyStack(a));
            Console.WriteLine(FirstDuplicatebyDictionary(a));

            Console.ReadKey();
        }
    }
}

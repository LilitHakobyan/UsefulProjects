using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
     
    class Base
    {

        public Base()
        {
            Console.WriteLine("Def ctor Base");
        }

        public void Displa()
        {
            Console.WriteLine("Method of Base Display");
        }
    }

    class Dir : Base
    {
        public Dir()
        {
            Console.WriteLine("dir dif ctor");
        }

        public void Show()
        {
            Console.WriteLine("Methof od Dir Show");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dir dir = new Dir();
            Base ba = dir;
            Dir d1 = (Dir) ba;
           
        }
    }
}

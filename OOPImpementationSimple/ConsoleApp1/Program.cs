using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PolimorphismTest
{
    public class A
    {
        public virtual void DoWork()
        {
            Console.WriteLine("A");
        }
    }
    public class B : A
    {
        public override void DoWork()
        {
            Console.WriteLine("B");
        }
    }
    public class C : B
    {
        public sealed override void DoWork()
        {
            Console.WriteLine("C");
        }
    }
    public class D : C
    {
        public new void DoWork()
        {
            Console.WriteLine("D");
        }
    }
    
    class Program
    {

        static void Main(string[] args)
        {
            
            D d = new D();
            Console.WriteLine(d.GetType());
            d.DoWork();

            C c = d;
            Console.WriteLine(c.GetType());
            c.DoWork();

            B b = c;
            Console.WriteLine(b.GetType());
            b.DoWork();

            A a = b;
            Console.WriteLine(a.GetType());
            a.DoWork();

            //A a1 = new A();
            //a1.DoWork();
            //B b1 = new B();
            //b1.DoWork();
            //A a2 = b1;
            //a2.DoWork();
            Console.ReadKey();
        }
    }
}

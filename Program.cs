using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitImplementation
{
    class MyClass
    {

        public void Operation()
        {
            Console.WriteLine("Operation ThreadId {0}", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Begin");
            Thread.Sleep(2000);
            Console.WriteLine("End");
        }
        public async void OperationAsync()
        {
            Console.WriteLine("OperationAsync 1 ThreadId {0}", Thread.CurrentThread.ManagedThreadId);
            Task task = new Task(Operation);
            task.Start();
            await task;
            Console.WriteLine("OperationAsync 2 ThreadId {0}", Thread.CurrentThread.ManagedThreadId);

        }
    }
    class DecompildMyClass
    {
        public void Operation()
        {
            Console.WriteLine("Operation ThreadId {0}", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Begin");
            Thread.Sleep(2000);
            Console.WriteLine("End");
        }
        public void OperationAsync()
        {
            AsyncStateMachine stateMachine;
            stateMachine.outer = this;
            stateMachine.builder = AsyncVoidMethodBuilder.Create();
            stateMachine.state = -1;
            stateMachine.builder.Start(ref stateMachine); // call MoveNext()
        }
        private struct AsyncStateMachine : IAsyncStateMachine
        {
            public DecompildMyClass outer;
            public AsyncVoidMethodBuilder builder;
            public int state;

            void IAsyncStateMachine.MoveNext()
            {
                if (state == -1)
                {
                    Console.WriteLine("OperationAsync (Part 1 ThreadID {0}\r", Thread.CurrentThread.ManagedThreadId);

                    Task task = new Task(outer.Operation);
                    task.Start();

                    state = 0;
                    TaskAwaiter awaiter = task.GetAwaiter();
                    builder.AwaitOnCompleted(ref awaiter, ref this); // build calls move next second time
                    return; // end 
                }
                Console.WriteLine("\n OperationAsync (Part2 ) ThreadID {0}", Thread.CurrentThread.ManagedThreadId);
            }
            // builder.AwaitOnCompleted call this method sync
            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                builder.SetStateMachine(stateMachine);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main ThreadID {0}", Thread.CurrentThread.ManagedThreadId);
            MyClass my = new MyClass();
            my.OperationAsync();
            Console.ReadKey();
        }
    }
}

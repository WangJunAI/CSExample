using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSExample
{
    public class 异步方法
    {
        public async void Run()
        {
            Console.WriteLine("在异步方法.Run中1 , 当前线程ID {0}", Thread.CurrentThread.ManagedThreadId);
            var task =Async01();
            Console.WriteLine("在异步方法.Run中2 , 当前线程ID {0}", Thread.CurrentThread.ManagedThreadId);
            await task;

        }

        public async Task  Async01()
        {
            Console.WriteLine("在异步方法.Async01中1 , 当前线程ID {0}", Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(3000);
            Console.WriteLine("在异步方法.Async01中2, 当前线程ID {0}", Thread.CurrentThread.ManagedThreadId);
        }
    }
}

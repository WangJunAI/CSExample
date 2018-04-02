using ServiceReference1;
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var svr1 = new Service1Client();
            var task = svr1.GetDataAsync(1);
            var rrs = task.Result;
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}

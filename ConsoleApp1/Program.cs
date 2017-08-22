using CSExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ///扩展方法
            Base1 b = new Base1();
            b.Base1_Method2();

            ///弱引用样例
            WeakRef r = new WeakRef();
            r.Run();

            ///可选参数
            可选参数 k = new 可选参数();
            k.Run();
            k.Run("顺序一致字符串",6,22.22f);
            k.Run(i:9,f:77.77f,str:"顺序不一致字符串");

            Console.ReadKey();
        }
    }
}

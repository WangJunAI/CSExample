using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExample
{
    public class Base1
    {
        public void Method1()
        {

        }
    }

    public static class Extension1
    {
        public static void Base1_Method2(this Base1  base1)
        {
            ///C# Compiler 编译的过程是这样的：
            ///● 首先查看Person类中是否有ExtensionMethod()方法，有的话，直接调用；
            ///● 如果没有，在相应的NameSpace 当中，查找static Class，看看这些static Class当中，是否有public static void ExtensionMethod(this Person p) 这样的方法，如果也没有，编译通不过。
            Console.WriteLine("扩展方法示例");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExample
{
    public class 可选参数
    {
        public void Run(string str="字符串默认值", int i=99,float f=88.88f)
        {
            Console.WriteLine("{0}\t{1}\t{2}\t",str,i,f);
        }
    }
}

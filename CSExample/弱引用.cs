using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExample
{
    public class WeakRef
    {
        public void Run()
        {
            string data = "弱引用演示：要保存的对象";
            WeakReference weakRef = new WeakReference(data);
            Console.WriteLine(weakRef.Target);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExample
{
    public class 动态对象
    {
        public void Run()
        {
            dynamic eo = new ExpandoObject();
            eo.Name = "汪俊";
            eo.Show = new Func<dynamic, dynamic>((dynamic d) =>
           {
               Console.WriteLine("动态对象使用 " + d.Name);
               return null;
           });

            eo.Show(eo);
        }
    }
}

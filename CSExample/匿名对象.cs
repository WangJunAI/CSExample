using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExample
{
    public class 匿名对象
    {
        public void Run()
        {
            var entity = new { Name="汪俊",Age=50};

            Console.WriteLine(entity);
        }
    }
}

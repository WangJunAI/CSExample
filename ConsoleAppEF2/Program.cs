using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEF2
{
    class Program
    {
        static void Main(string[] args)
        {
            var connStr = @"Data Source=hds260381389.my3w.com;Initial Catalog=hds260381389_db;Persist Security Info=True;User ID=hds260381389;Password=75737573";
            var item = new Test() { Name=DateTime.Now.ToString(),Name2=new Random().NextDouble().ToString()};
            TestDB<Test>.CreateInstance(connStr).Save(item);

        }
    }
}

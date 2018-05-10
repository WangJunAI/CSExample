using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEF1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AUDUSDContext())
            {
                var inst = new AUDUSD();
                inst.OpenPrice = 0.1f;
                inst.HighPrice = 0.1f;
                inst.LowPrice = 0.1f;
                inst.ClosePrice = 0.1f;
                inst.TimeTick = 1;
                inst.TradingTime = DateTime.Now;
                inst.Type = "AUDUSD";
                db.AUDUSDs.Add(inst);
                db.SaveChanges();
            }

            Console.WriteLine("全部结束");
            Console.ReadKey();
        }
    }
}

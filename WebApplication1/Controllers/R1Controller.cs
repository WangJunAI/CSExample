using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class R1Controller : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "R1 Index";

            return View("../Home/Test");
        }

        public ActionResult Test(string json)
        {
            ViewBag.Title = "R1 Test";
            var data = json;
            var res =  new JsonResult();
            res.JsonRequestBehavior =  JsonRequestBehavior.AllowGet;
            res.Data = new { Name = "WangJun" };
            return res;
        }


    }
}

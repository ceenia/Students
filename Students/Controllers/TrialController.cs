using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Students.Controllers
{
    public class TrialController : Controller
    {
        // get: student
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello dfgdfg" + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }
        //public string index(string name, int numTimes = 1)
        //{
        //    return HttpUtility.HtmlAttributeEncode("Hello " + name + ", NumTimes is: " + numTimes);
        //}
    }
}
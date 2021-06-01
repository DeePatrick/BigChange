using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BigChange.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IEnumerable<int> Numbers = Enumerable.Range(1, 100)
            .Where(num => num % 5 == 0 || num % 3 == 0)
            .Take(50)
            .Select(val => val);

            ViewData.Model = Numbers;

            //return Json(Numbers, JsonRequestBehavior.AllowGet);
            return View(Numbers);
        }
    }
}
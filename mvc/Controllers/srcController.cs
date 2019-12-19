using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc.Controllers
{
    public class srcController : Controller
    {
        public ActionResult Index(DateTime? start, DateTime? end)
        {
            if (!start.HasValue && !end.HasValue)
            {
                ViewBag.StartDate = DateTime.Parse("2019-06-01");
                ViewBag.EndDate = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd") + " 23:59:59.000");
            }
            else
            {
                ViewBag.StartDate = start;
                ViewBag.EndDate = end;
            }
            return View();
        }
    }
}

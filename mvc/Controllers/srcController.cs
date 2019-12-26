using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc.Controllers
{
    public class srcController : Controller
    {
        public ActionResult index(DateTime? start, DateTime? end, int? page)
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
                ViewBag.EndDate = DateTime.Parse(ViewBag.EndDate.ToString("yyyy-MM-dd") + " 23:59:59.000");
            }
            
            if (!page.HasValue) { ViewBag.PageNumber = 1; }
            else { ViewBag.PageNumber = (page <= 1 ? 1 : page); }

            return View();
        }

        public ActionResult test()
        {
            return View();
        }
    }
}

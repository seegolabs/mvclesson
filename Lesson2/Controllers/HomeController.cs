using Lesson2.Infrastructures;
using Lesson2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson2.Controllers
{
    public class HomeController : Controller
    {
        private DataContext ctx;

        public HomeController()
        {
            ctx = new DataContext();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            var list = ctx.Registrations;
            return View(list);
        }

        public ActionResult Registration()
        {
            var model = new Registration
            {
                RegDate = DateTime.Now
            };

            ViewBag.CourseCbo = ctx.PackageCourses.Select(p => new SelectListItem { Text = p.PackageName, Value = p.PackageCode }).ToList();
            return View(model);
        }

        public ActionResult About()
        {
            return View();
        }

        public JsonResult CourseList()
        {
            var list = ctx.PackageCourses;
            return Json(list, JsonRequestBehavior.AllowGet);
        }

    }
}

using MvcLearn.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcLearn.Controllers
{
    public class RegistrationController : DbController
    {
        public ActionResult Index()
        {
            var list = ctx.Registrations;
            return View(list);
        }

        public ActionResult Create()
        {
            var model = new Registration();
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(Registration model)
        {
            if (ModelState.IsValid)
            {
                model.RegID = Guid.NewGuid().ToString();
                ctx.Registrations.Add(model);
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public ActionResult Edit(string id)
        {
            var model = ctx.Registrations.Find(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(Registration model)
        {
            if (ModelState.IsValid)
            {
                ctx.Entry(model).State = EntityState.Modified;
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public ActionResult Details(string id)
        {
            var model = ctx.Registrations.Find(id);
            return View(model);
        }

        public ActionResult Delete(string id)
        {
            var model = ctx.Registrations.Find(id);
            return View(model);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {
            var model = ctx.Registrations.Find(id);
            ctx.Registrations.Remove(model);
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

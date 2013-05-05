using MvcLearn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcLearn.Controllers
{
    public class DbController : Controller
    {
        protected DataContext ctx = new DataContext();
    }
}

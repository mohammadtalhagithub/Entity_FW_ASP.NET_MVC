using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstApproach_EntityFw.Controllers
{
    public class HomeController : Controller
    {
        StudentContext db = new StudentContext();

        // GET: Home
        public ActionResult Index()
        {
            var data = db.Students.ToList();

            return View(data);
        }

        public ActionResult StudentsView()
        {
            var data = db.Students.ToList();

            return View(data);
        }
    }
}
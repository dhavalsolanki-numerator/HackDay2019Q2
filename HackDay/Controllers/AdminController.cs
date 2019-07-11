using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HackDay.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult Users()
        {
            return View();
        }

        public ActionResult EditUser()
        {
            return View();
        }

        public ActionResult Quarters()
        {
            return View();
        }

        public ActionResult EditQuarter()
        {
            return View();
        }

        public ActionResult Idea()
        {
            return View();
        }
        public ActionResult IdeaAddEdit()
        {
            return View();
        }
        public ActionResult Team()
        {
            return View();
        }
        public ActionResult TeamddEdit()
        {
            return View();
        }
    }
}
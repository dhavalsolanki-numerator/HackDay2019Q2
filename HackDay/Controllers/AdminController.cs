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
<<<<<<< HEAD

        public ActionResult Users()
        {
            return View();
        }

        public ActionResult EditUser()
        {
            return View();
        }
=======
        public ActionResult Idea()
        {
            return View();
        }
        public ActionResult IdeaAddEdit()
        {
            return View();
        }

>>>>>>> ba15cbf337241f81133eb8841fc91f990c6175a6
    }
}
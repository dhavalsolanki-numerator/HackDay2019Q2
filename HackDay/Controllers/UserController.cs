using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HackDay.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Dashboard()
        {
            return View();
        }
        public ActionResult Archive()
        {
            return View();
        }
        public ActionResult PendingRequest()
        {
            return View();
        }
        public ActionResult SubmitIdea()
        {
            return View();
        }

    }
}
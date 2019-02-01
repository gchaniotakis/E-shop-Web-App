using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eshopapp.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult HomeView()
        {
            return View();
        }

        public ActionResult NewUser()
        {
            return View();
        }

        public ActionResult InsertUser(string name)
        {
            return View(name);
        }
    }
}
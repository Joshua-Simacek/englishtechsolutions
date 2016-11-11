using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EnglishTechSolutions.Controllers
{
    public class SpecialController : Controller
    {
        private readonly string pass = ConfigurationManager.AppSettings["special"];
        // GET: Special
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Auth(string password)
        {
            if(password != pass)
            {
                return RedirectToAction("Index");
            }

            return RedirectToAction("Special", new { password });
        }

        public ActionResult Special(string password)
        {
            if(password != pass)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
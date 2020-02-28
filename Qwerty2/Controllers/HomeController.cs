using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Qwerty2.Services;

namespace Qwerty2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            var aboutPageService = new AboutPageService();

            var about = aboutPageService.GetAboutPage();

            return View(about);
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}
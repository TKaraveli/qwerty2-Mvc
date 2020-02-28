using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Qwerty2.Entities;
using Qwerty2.Services;

namespace Qwerty2.Controllers
{
    public class HomeController : Controller
    {
        private readonly AboutPageService aboutPageService;
        private readonly ContactPageService contactPageService;

        public HomeController()
        {
            aboutPageService = new AboutPageService();
            contactPageService = new ContactPageService();
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult About()
        {
            AboutPage about = aboutPageService.GetAboutPage();

            return View(about);
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ContactPage contact = contactPageService.GetContactPage();

            if (contact == null)
                return View("_NotFound");
            
            return View(contact);
        }
    }
}
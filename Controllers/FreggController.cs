using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fregg_Template.Helper;
using Fregg_Template.Model;

namespace Fregg_Template.Controllers
{
    public class FreggController : Controller
    {
        // GET: Fregg
        public ActionResult HomePage()
        {
            ViewBag.year = Year.GetCurrentYear();
            return View();
        }
        public ActionResult AboutPage()
        {
            return View();
        }
        public ActionResult ServicePage()
        {
            return View();
        }
        public ActionResult ContactPage()
        {
            var form = new Form();
            form.name = "Name";
            form.email = "Email";
            form.message = "Message";
            return View(form);
        }
    }
}
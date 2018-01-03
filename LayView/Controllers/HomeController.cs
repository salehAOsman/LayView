using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayView.Controllers
{
    public class HomeController : Controller
    {
        //Get: Index
        public ActionResult Index()
        {
            
            return View();
        }
        // GET: About
        public ActionResult About()
        {

            return View();
        }
        // Get: Contact
        public ActionResult Contact()
        {
            ViewBag.Name = "Saleh Osman";
            ViewBag.Phone = "0764–191954";
            ViewBag.ePost = "Mail:saleh1.a.osman@gmail.com";
            ViewBag.Address = "Kronotorpsvägen3C,37161Lyckeby";

            return View();
        }
        // Get: Projects
        public ActionResult Projects()
        {
            ViewBag.projects = "Projects I have finished:";
            return View();
        }
    }
}
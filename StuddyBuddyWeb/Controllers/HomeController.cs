using StuddyBuddyWeb.Processors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudyLabsWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page";

            return View();
        }

        public ActionResult Rankings(string selectedFaculty)
        {
            ViewBag.Message = "Rankings";

            AStuddyBuddyProcessor studdyBuddyList = new AStuddyBuddyProcessor();
            studdyBuddyList.LoadData(selectedFaculty);

            return View(studdyBuddyList);
        }
    }
}
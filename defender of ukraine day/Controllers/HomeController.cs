using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace defender_of_ukraine_day.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();

        }
        public ActionResult History()
        {
            ViewBag.Message = "День захисника України (День захисників Вітчизни)";

            return View();
        }
        public ActionResult Poll()
        {
            ViewBag.Message = "Опитування";

            return View();
        }
        public ActionResult Facts()
        {
            ViewBag.Message = "Факти";

            return View();
        }
        public ActionResult Nuwm()
        {
            ViewBag.Message = "Воднік";

            return View();
        }
        public ActionResult Game()
        {
            ViewBag.Message = "Ігра";

            return View();
        }
    }
}
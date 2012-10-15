using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelPaladium.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to kick-start your ASP.NET MVC application.";

            return View();
        }
        public ActionResult Habitaciones()
        {
            ViewBag.Message = "Bienvenido a nuestras Habitaciones";
            return View();
        }
        public ActionResult Reservas()
        {
            ViewBag.Message = "Bienvenido a nuestras Reservas";
            return View();
        }
        public ActionResult Servicios()
        {
            ViewBag.Message = "Bienvenido a nuestra Servicios";
            return View();
        }
        public ActionResult Galeria() {
            ViewBag.Message = "Bienvenido a nuestra galeria";
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }
    }
}

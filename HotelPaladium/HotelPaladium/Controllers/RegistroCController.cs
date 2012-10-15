using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelPaladium.Models;

namespace HotelPaladium.Controllers
{
    public class RegistroCController : Controller
    {
        //
        // GET: /RegistroC/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult RegistroCliente()
        {
            ViewBag.Message = "Registro de nuestros Clientes";
            return View();
        }

    }
}

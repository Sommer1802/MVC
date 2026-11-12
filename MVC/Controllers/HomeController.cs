using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Cantidad de registros de cada sección para mostrarlos en el inicio
            ViewBag.Clientes = Datos.Clientes.Count;
            ViewBag.Tecnicos = Datos.Tecnicos.Count;
            ViewBag.Electrodomesticos = Datos.Electrodomesticos.Count;
            ViewBag.Reparaciones = Datos.Reparaciones.Count;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Cómo está organizado el aplicativo con el patrón MVC.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Comuníquese con el taller.";

            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class ElectrodomesticoController : Controller
    {
        // Listado de electrodomésticos
        public ActionResult Index()
        {
            return View(Datos.Electrodomesticos);
        }

        // Muestra el formulario vacío
        public ActionResult Crear()
        {
            return View();
        }

        // Recibe los datos del formulario y muestra el electrodoméstico registrado
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Crear(Electrodomesticos obj)
        {
            if (Datos.Electrodomesticos.Any(e => e.Modelo == obj.Modelo))
            {
                ModelState.AddModelError("Modelo", "Ya existe un electrodoméstico con ese modelo");
            }

            if (!ModelState.IsValid)
            {
                return View(obj);
            }

            Datos.Electrodomesticos.Add(obj);
            return View("Detalle", obj);
        }
    }
}

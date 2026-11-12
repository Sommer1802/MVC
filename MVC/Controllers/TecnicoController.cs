using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class TecnicoController : Controller
    {
        // Listado de técnicos
        public ActionResult Index()
        {
            return View(Datos.Tecnicos);
        }

        // Muestra el formulario vacío
        public ActionResult Crear()
        {
            return View();
        }

        // Recibe los datos del formulario y muestra el técnico registrado
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Crear(Tecnico obj)
        {
            if (Datos.Tecnicos.Any(t => t.NIF == obj.NIF))
            {
                ModelState.AddModelError("NIF", "Ya existe un técnico con ese NIF");
            }

            if (!ModelState.IsValid)
            {
                return View(obj);
            }

            Datos.Tecnicos.Add(obj);
            return View("Detalle", obj);
        }
    }
}

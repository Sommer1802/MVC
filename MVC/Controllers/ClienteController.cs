using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class ClienteController : Controller
    {
        public ActionResult Index()
        {
            return View(Datos.Clientes);
        }

        public ActionResult Crear()
        {
            return View();
        }

        // Recibe los datos del formulario y muestra el cliente registrado
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Crear(Cliente obj)
        {
            if (Datos.Clientes.Any(c => c.DNI == obj.DNI))
            {
                ModelState.AddModelError("DNI", "Ya existe un cliente con ese DNI");
            }

            if (!ModelState.IsValid)
            {
                return View(obj);
            }

            Datos.Clientes.Add(obj);
            return View("Detalle", obj);
        }

        // Busca un cliente por su DNI y muestra sus reparaciones
        public ActionResult Buscar(string dni)
        {
            ViewBag.DNI = dni;

            if (string.IsNullOrWhiteSpace(dni))
            {
                return View();
            }

            Cliente obj = Datos.Clientes.FirstOrDefault(c => c.DNI == dni.Trim());
            if (obj != null)
            {
                ViewBag.Reparaciones = Datos.Reparaciones.Where(r => r.DNICliente == obj.DNI).ToList();
            }

            return View(obj);
        }
    }
}

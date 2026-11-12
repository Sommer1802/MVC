using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class ReparacionController : Controller
    {
        // Listado de reparaciones
        public ActionResult Index()
        {
            return View(Datos.Reparaciones);
        }

        // Muestra el formulario con la fecha y hora actuales
        public ActionResult Crear()
        {
            CargarListas();
            Reparacion obj = new Reparacion
            {
                Fecha = DateTime.Today,
                Hora = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, 0)
            };
            return View(obj);
        }

        // Recibe los datos del formulario y muestra la reparación registrada
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Crear(Reparacion obj)
        {
            if (!ModelState.IsValid)
            {
                CargarListas();
                return View(obj);
            }

            Datos.Reparaciones.Add(obj);
            return View("Detalle", obj);
        }

        // Listas desplegables para escoger cliente, técnico y electrodoméstico
        private void CargarListas()
        {
            ViewBag.Clientes = new SelectList(
                Datos.Clientes.Select(c => new { c.DNI, Texto = c.Nombre + " " + c.Apellidos + " (" + c.DNI + ")" }),
                "DNI", "Texto");
            ViewBag.Tecnicos = new SelectList(
                Datos.Tecnicos.Select(t => new { t.NIF, Texto = t.Nombre + " " + t.Apellidos + " (" + t.NIF + ")" }),
                "NIF", "Texto");
            ViewBag.Electrodomesticos = new SelectList(
                Datos.Electrodomesticos.Select(e => new { e.Modelo, Texto = e.Tipo + " " + e.Modelo }),
                "Modelo", "Texto");
        }
    }
}

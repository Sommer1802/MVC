using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    // Dos objetos de ejemplo por cada clase. Los que se crean desde los
    // formularios se agregan a estas listas mientras la aplicación esté corriendo.
    public static class Datos
    {
        public static List<Cliente> Clientes = new List<Cliente>
        {
            new Cliente { Nombre = "Carlos", Apellidos = "Pérez Rodríguez", DNI = "1045678901", Direccion = "Calle 10 # 5-20", Telefono = "3001234567" },
            new Cliente { Nombre = "Laura", Apellidos = "Gómez Herrera", DNI = "1047890123", Direccion = "Carrera 7 # 45-12", Telefono = "3109876543" }
        };

        public static List<Tecnico> Tecnicos = new List<Tecnico>
        {
            new Tecnico { Nombre = "Andrés", Apellidos = "Ruiz Castro", NIF = "001", Movil = "3157778899" },
            new Tecnico { Nombre = "Sofía", Apellidos = "Martínez Díaz", NIF = "002", Movil = "3204445566" }
        };

        public static List<Electrodomesticos> Electrodomesticos = new List<Electrodomesticos>
        {
            new Electrodomesticos { Tipo = "Nevera", Modelo = "LG GT32", Precio = 1800000m },
            new Electrodomesticos { Tipo = "Lavadora", Modelo = "Samsung WA17", Precio = 1500000m }
        };

        public static List<Reparacion> Reparaciones = new List<Reparacion>
        {
            new Reparacion { Descripcion = "Cambio de compresor", Fecha = new DateTime(2026, 11, 3), Hora = new TimeSpan(9, 30, 0), Coste = 350000m, Garantia = true, DNICliente = "1045678901", NIFTecnico = "001", ModeloElectrodomestico = "LG GT32" },
            new Reparacion { Descripcion = "Cambio de motor", Fecha = new DateTime(2026, 11, 5), Hora = new TimeSpan(14, 0, 0), Coste = 280000m, Garantia = false, DNICliente = "1047890123", NIFTecnico = "002", ModeloElectrodomestico = "Samsung WA17" }
        };
    }
}

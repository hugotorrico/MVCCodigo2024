using MVCCodigo2024.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Web;
using System.Web.Mvc;

namespace MVCCodigo2024.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes
        public ActionResult Index()
        {
            //Ir a la base de datos
            List<Cliente> model = new List<Cliente>();
            model.Add(new Cliente { Id = 1, Nombres = "Nombres", Apellidos = "Apellidos", Edad = 20 });
            model.Add(new Cliente { Id = 1, Nombres = "Nombres", Apellidos = "Apellidos", Edad = 20 });
            model.Add(new Cliente { Id = 1, Nombres = "Nombres", Apellidos = "Apellidos", Edad = 20 });
            model.Add(new Cliente { Id = 1, Nombres = "Nombres", Apellidos = "Apellidos", Edad = 20 });
            model.Add(new Cliente { Id = 1, Nombres = "Nombres", Apellidos = "Apellidos", Edad = 20 });
            model.Add(new Cliente { Id = 1, Nombres = "Nombres", Apellidos = "Apellidos", Edad = 20 });


            return View(model);
        }


        public ActionResult Create()
        {
            Cliente model = new Cliente();
            return View(model);
        }
        public ActionResult Edit()
        {
            Cliente model = new Cliente();
            return View(model);
        }
    }
}
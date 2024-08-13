using MVCCodigo2024.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCodigo2024.Controllers
{
    public class ProductosClientesController : Controller
    {
        // GET: ProductosClientes
        public ActionResult Listar()
        {
            ProductoCliente model = new ProductoCliente();

            return View(model);
        }
    }
}
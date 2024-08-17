using MvcCodigoPartials.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCodigoPartials.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            Usuario usuario = new Usuario();
            return View(usuario);
        }
        public ActionResult Edit()
        {
            Usuario usuario = new Usuario();
            return View(usuario);
        }
    }
}
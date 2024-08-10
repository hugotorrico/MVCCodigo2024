using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCodigo2024.Controllers
{
    public class DemoController : Controller
    {
        //ActionResult=>html
        public string HolaMundo()
        {
            return "<h1>Hola Mundo</h1>";
        }
        public string HolaCodigo()
        {
            return "<h1>Hola Codigo</h1>";
        }

        public string Formulario()
        {
            string simpleForm = @"
<form action='/submit' method='post'>
    <label for='name'>Name:</label><br>
    <input type='text' id='name' name='name'><br><br>
    <label for='email'>Email:</label><br>
    <input type='email' id='email' name='email'><br><br>
    <input type='submit' value='Submit'>
</form>";

            return simpleForm;
        }

        // GET: Demo
        public ActionResult Index()
        {
            Session["Mensaje"] = "SOY EL PROFESOR HUGO TORRICO";

            ViewBag.Mensaje = "Bienvenido a Codigo";
            ViewBag.FechaHora = DateTime.Now.ToLongDateString();

            if (DateTime.Now.Hour > 13)
                ViewBag.Saludo = "Buenas Tardes";
            else
                ViewBag.Saludo = "Buenas Días";



            return View();
        }

        // GET: Demo
        public ActionResult ListarPersonas()
        {
            return View();
        }





    }
}
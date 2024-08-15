using MVCCodigo2024.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace MVCCodigo2024.Controllers
{
    public class PersonasController : Controller
    {
        // GET: Personas
        public ActionResult Index()
        {
            List<Persona> personas = new List<Persona>();

            //Si se ingresa por primera vez, se llena la sesión
            if (Session["Personas"]==null)
            {
                personas.Add(new Persona { Id = 1, Apellidos = "Torrico", Nombres = "Hugo" });
                personas.Add(new Persona { Id = 2, Apellidos = "Márquez", Nombres = "Felipe" });
                Session["Personas"] = personas;
            }
            //la sesión ya viene con información, es mostrar en la vista
            else
            {
                personas = (List<Persona>)Session["Personas"];
            }                
            return View(personas);
        }

        // GET: Personas/Details/5
        public ActionResult Details(int id)
        {
            Persona persona = ((List<Persona>)Session["Personas"]).Where(x => x.Id == id).FirstOrDefault();
            return View(persona);
        }

        // GET: Personas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Personas/Create
        [HttpPost]
        public ActionResult Create(Persona persona)
        {
            try
            {               
                int maxId = ((List<Persona>)Session["Personas"]).Max(p => p.Id);
                persona.Id = maxId + 1;
                // TODO: Add insert logic here
                ((List<Persona>)Session["Personas"]).Add(persona);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Personas/Edit/5
        public ActionResult Edit(int id)
        {
            Persona persona = ((List<Persona>)Session["Personas"]).Where(x => x.Id == id).FirstOrDefault();
            return View(persona);
       
        }

        // POST: Personas/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Persona persona)
        {
            try
            {
                // TODO: Add update logic here

                //Busco a la persona que voy a eliminar
                Persona personEditar = ((List<Persona>)Session["Personas"]).Where(x => x.Id == id).FirstOrDefault();
                personEditar.Nombres = persona.Nombres;
                personEditar.Apellidos = persona.Apellidos;

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Personas/Delete/5
        public ActionResult Delete(int id)
        {
            Persona persona = ((List<Persona>)Session["Personas"]).Where(x => x.Id == id).FirstOrDefault();   
            return View(persona);
        }

        // POST: Personas/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Persona persona)
        {
            try
            {                            
                //Busco a la persona que voy a eliminar
                Persona personaEliminar = ((List<Persona>)Session["Personas"]).Where(x => x.Id == id).FirstOrDefault();
                ((List<Persona>)Session["Personas"]).Remove(personaEliminar);    

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

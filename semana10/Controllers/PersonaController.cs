using semana10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace semana10.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            List<Persona> personas = new List<Persona>();

            if (Session["personas"] == null)
                {
                    //Ir base de datos               
                    personas.Add(new Persona { Apellidos = "Blas", Nombres = "Evelyn", PersonaID = 1 });


                    Session["personas"] = personas;
                }
            else
            {
                personas = (List<Persona>)Session["personas"];
            }


            return View(personas);
        }

        public ActionResult Create()
        {
            return View(new Persona());
        }

        [HttpPost]
        public ActionResult Create(Persona persona)
        {

            ((List<Persona>)Session["personas"]).Add(persona);

            return RedirectToAction("Index");
        }
        public ActionResult Edit()
        {
            return View();

        }

        public ActionResult Delete()
        {
            return View();

        }


    }
}
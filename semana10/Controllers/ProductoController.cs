using semana10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace semana10.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
            public ActionResult Index()
            {

            List<Producto> productos = new List<Producto>();

            if (Session["productos"] == null)

                {
                    //Ir base de datos               
                    productos.Add(new Producto { Nombre = "Fresa", Descripcion = "en buen estado", Precio = 05.50m, ProductoID = 1 });

                    Session["productos"] = productos;
                }
            else
                {
                    productos = (List<Producto>)Session["productos"];
                }

            return View(productos);
            }

            public ActionResult Create()
            {
                return View();
            }

        [HttpPost]
        public ActionResult Create(Producto producto)
        {

            ((List<Persona>)Session["producto"]).Add(producto);

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
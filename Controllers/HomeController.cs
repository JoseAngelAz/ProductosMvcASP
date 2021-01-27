using ProductosApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductosApp.Controllers
{
    public class HomeController : Controller
    {
        Productos p = new Productos();
        public ActionResult Formulario()
        {
            return View();
        }
        public ActionResult AgregarProductos()
        {
            string id = Request.Form["id"].ToString();
            string n_producto = Request.Form["n_producto"].ToString();
            string descripcion = Request.Form["descripcion"].ToString();
            double precio = double.Parse(Request.Form["precio"].ToString());

            p.GuardarProducto(id,n_producto,descripcion,precio);
            return View();
        }
        public ActionResult MostrarProductos()
        {
            //llamar al metodo leer de la vista comentario
            string texto = p.MostrarProducto();
            ViewData["products"] = texto;

            return View();
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

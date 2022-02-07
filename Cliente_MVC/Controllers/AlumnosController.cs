using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cliente_MVC.ServicioMaestria;

namespace Cliente_MVC.Controllers
{
    public class AlumnosController : Controller
    {
        // GET: Alumnos

        AlumnosServiceClient SrvAlumnos = new AlumnosServiceClient();
        
        public ActionResult Index()
        {
            return View(SrvAlumnos.Consultar());
        }

        // GET: Alumnos/Details/5 
        public ActionResult Details(string nc)
        {
            var alumno = SrvAlumnos.BuscarxNC(nc);
            return View(alumno);
        }

        // GET: Alumnos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Alumnos/Create
        [HttpPost]
        public ActionResult Create([Bind(Include ="No_control,Apepat,Apemat,Nombre")] Alumno alumno)
        {
            try
            {
                // TODO: Add insert logic here
                SrvAlumnos.Agregar(alumno.No_control,alumno.Apemat,alumno.Apepat,alumno.Nombre);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Alumnos/Edit/5
        public ActionResult Edit(string nc)
        {
            var alumno = SrvAlumnos.BuscarxNC(nc);
            return View(alumno);

        }

        // POST: Alumnos/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "No_control,Apepat,Apemat,Nombre")] Alumno alumno)
        {
            try
            {
                // TODO: Add update logic here
                SrvAlumnos.Actualizar(alumno.No_control, alumno.Apemat, alumno.Apepat, alumno.Nombre);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Alumnos/Delete/5
        public ActionResult Delete(string nc)
        {
            var alumno = SrvAlumnos.BuscarxNC(nc);
            return View(alumno);
        }

        // POST: Alumnos/Delete/5
        [HttpPost]
        public ActionResult Delete(string nc, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                SrvAlumnos.Eliminar(nc);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

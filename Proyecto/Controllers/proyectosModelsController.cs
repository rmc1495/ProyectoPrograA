using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IdentitySample.Models;
using Proyecto.Models;

namespace Proyecto.Controllers
{
    public class proyectosModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: proyectosModels
        public ActionResult Index()
        {
            return View(db.proyectosModels.ToList());
        }

        // GET: proyectosModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            proyectosModels proyectosModels = db.proyectosModels.Find(id);
            if (proyectosModels == null)
            {
                return HttpNotFound();
            }
            return View(proyectosModels);
        }

        // GET: proyectosModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: proyectosModels/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,nombreproyecto,descripcionProyecto,tareaID")] proyectosModels proyectosModels)
        {
            if (ModelState.IsValid)
            {
                db.proyectosModels.Add(proyectosModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(proyectosModels);
        }

        // GET: proyectosModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            proyectosModels proyectosModels = db.proyectosModels.Find(id);
            if (proyectosModels == null)
            {
                return HttpNotFound();
            }
            return View(proyectosModels);
        }

        // POST: proyectosModels/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,nombreproyecto,descripcionProyecto,tareaID")] proyectosModels proyectosModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(proyectosModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(proyectosModels);
        }

        // GET: proyectosModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            proyectosModels proyectosModels = db.proyectosModels.Find(id);
            if (proyectosModels == null)
            {
                return HttpNotFound();
            }
            return View(proyectosModels);
        }

        // POST: proyectosModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            proyectosModels proyectosModels = db.proyectosModels.Find(id);
            db.proyectosModels.Remove(proyectosModels);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

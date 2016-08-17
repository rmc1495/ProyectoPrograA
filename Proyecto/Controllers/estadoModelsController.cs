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
    public class estadoModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: estadoModels
        public ActionResult Index()
        {
            return View(db.estadoModels.ToList());
        }

        // GET: estadoModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            estadoModels estadoModels = db.estadoModels.Find(id);
            if (estadoModels == null)
            {
                return HttpNotFound();
            }
            return View(estadoModels);
        }

        // GET: estadoModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: estadoModels/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,nombreEstado")] estadoModels estadoModels)
        {
            if (ModelState.IsValid)
            {
                db.estadoModels.Add(estadoModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(estadoModels);
        }

        // GET: estadoModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            estadoModels estadoModels = db.estadoModels.Find(id);
            if (estadoModels == null)
            {
                return HttpNotFound();
            }
            return View(estadoModels);
        }

        // POST: estadoModels/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,nombreEstado")] estadoModels estadoModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(estadoModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(estadoModels);
        }

        // GET: estadoModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            estadoModels estadoModels = db.estadoModels.Find(id);
            if (estadoModels == null)
            {
                return HttpNotFound();
            }
            return View(estadoModels);
        }

        // POST: estadoModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            estadoModels estadoModels = db.estadoModels.Find(id);
            db.estadoModels.Remove(estadoModels);
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

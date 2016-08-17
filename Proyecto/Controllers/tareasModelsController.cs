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
    public class tareasModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: tareasModels
        public ActionResult Index()
        {
            return View(db.tareasModels.ToList());
        }

        // GET: tareasModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tareasModels tareasModels = db.tareasModels.Find(id);
            if (tareasModels == null)
            {
                return HttpNotFound();
            }
            return View(tareasModels);
        }

        // GET: tareasModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tareasModels/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,nombreTarea,descripcion,tiempo")] tareasModels tareasModels)
        {
            if (ModelState.IsValid)
            {
                db.tareasModels.Add(tareasModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tareasModels);
        }

        // GET: tareasModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tareasModels tareasModels = db.tareasModels.Find(id);
            if (tareasModels == null)
            {
                return HttpNotFound();
            }
            return View(tareasModels);
        }

        // POST: tareasModels/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,nombreTarea,descripcion,tiempo")] tareasModels tareasModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tareasModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tareasModels);
        }

        // GET: tareasModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tareasModels tareasModels = db.tareasModels.Find(id);
            if (tareasModels == null)
            {
                return HttpNotFound();
            }
            return View(tareasModels);
        }

        // POST: tareasModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tareasModels tareasModels = db.tareasModels.Find(id);
            db.tareasModels.Remove(tareasModels);
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

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DragonBallZMVC.Models;

namespace DragonBallZMVC.Controllers
{
    public class GuerreroesController : Controller
    {
        private DragonBallContext db = new DragonBallContext();

        // GET: Guerreroes
        public ActionResult Index()
        {
            return View(db.Guerreros.ToList());
        }

        // GET: Guerreroes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Guerrero guerrero = db.Guerreros.Find(id);
            if (guerrero == null)
            {
                return HttpNotFound();
            }
            return View(guerrero);
        }

        // GET: Guerreroes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Guerreroes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GuerreroId,Nombre,Raza,NivelPoder,Transformacion")] Guerrero guerrero)
        {
            if (ModelState.IsValid)
            {
                db.Guerreros.Add(guerrero);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(guerrero);
        }

        // GET: Guerreroes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Guerrero guerrero = db.Guerreros.Find(id);
            if (guerrero == null)
            {
                return HttpNotFound();
            }
            return View(guerrero);
        }

        // POST: Guerreroes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GuerreroId,Nombre,Raza,NivelPoder,Transformacion")] Guerrero guerrero)
        {
            if (ModelState.IsValid)
            {
                db.Entry(guerrero).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(guerrero);
        }

        // GET: Guerreroes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Guerrero guerrero = db.Guerreros.Find(id);
            if (guerrero == null)
            {
                return HttpNotFound();
            }
            return View(guerrero);
        }

        // POST: Guerreroes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Guerrero guerrero = db.Guerreros.Find(id);
            db.Guerreros.Remove(guerrero);
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

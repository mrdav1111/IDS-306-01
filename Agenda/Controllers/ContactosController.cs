using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Agenda.Models;

namespace Agenda.Controllers
{
    public class ContactosController : Controller
    {
        private atributosDBContext db = new atributosDBContext();

        // GET: Contactos
        public ActionResult Index()
        {
            return View(db.Agenda.ToList());
        }

        // GET: Contactos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            atributos atributos = db.Agenda.Find(id);
            if (atributos == null)
            {
                return HttpNotFound();
            }
            return View(atributos);
        }

        // GET: Contactos/Create
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult acerca()
        {
            return View();
        }
        // POST: Contactos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Telefono,Nombre,Fecha,Correo,Direccion")] atributos atributos)
        {
            if (ModelState.IsValid)
            {
                db.Agenda.Add(atributos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(atributos);
        }

        // GET: Contactos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            atributos atributos = db.Agenda.Find(id);
            if (atributos == null)
            {
                return HttpNotFound();
            }
            return View(atributos);
        }

        // POST: Contactos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Telefono,Nombre,Fecha,Correo,Direccion")] atributos atributos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(atributos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(atributos);
        }

        // GET: Contactos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            atributos atributos = db.Agenda.Find(id);
            if (atributos == null)
            {
                return HttpNotFound();
            }
            return View(atributos);
        }

        // POST: Contactos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            atributos atributos = db.Agenda.Find(id);
            db.Agenda.Remove(atributos);
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

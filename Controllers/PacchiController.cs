using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MAEPacchi.Models;

namespace MAEPacchi.Controllers
{
    public class PacchiController : Controller
    {
        private PaccoDBContext db = new PaccoDBContext();

        // GET: Pacchi
        public ActionResult Index(string searchString)
        {
            var pacchi = from m in db.Pacchi
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                pacchi = pacchi.Where(s => s.Sender.Contains(searchString));
            }
            return View(pacchi);
        }

        // GET: Pacchi/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pacco pacco = db.Pacchi.Find(id);
            if (pacco == null)
            {
                return HttpNotFound();
            }
            return View(pacco);
        }

        // GET: Pacchi/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pacchi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Sender,Recipient,Date,Note,Price")] Pacco pacco)
        {
            if (ModelState.IsValid)
            {
                db.Pacchi.Add(pacco);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pacco);
        }

        // GET: Pacchi/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pacco pacco = db.Pacchi.Find(id);
            if (pacco == null)
            {
                return HttpNotFound();
            }
            return View(pacco);
        }

        // POST: Pacchi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Sender,Recipient,Date,Note,Price")] Pacco pacco)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pacco).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pacco);
        }

        // GET: Pacchi/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pacco pacco = db.Pacchi.Find(id);
            if (pacco == null)
            {
                return HttpNotFound();
            }
            return View(pacco);
        }

        // POST: Pacchi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pacco pacco = db.Pacchi.Find(id);
            db.Pacchi.Remove(pacco);
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

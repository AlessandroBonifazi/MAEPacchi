using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace MAEPacchi.Controllers
{
    public class PacchiController : Controller
    {
        // GET: Pacchi
        public ActionResult Index()
        {
            ViewBag.NSpedizioni = 5;
            ViewBag.codSpedizione = "ABC123";
            return View();
        }

        // GET: Pacchi/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Pacchi/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pacchi/Create
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

        // GET: Pacchi/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Pacchi/Edit/5
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

        // GET: Pacchi/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Pacchi/Delete/5
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

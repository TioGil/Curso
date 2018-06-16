using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BlogCourse.Models;

namespace BlogCourse.Controllers
{
    public class TestCsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: TestCs
        public ActionResult Index()
        {
            return View(db.Tests.ToList());
        }

        // GET: TestCs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestC testC = db.Tests.Find(id);
            if (testC == null)
            {
                return HttpNotFound();
            }
            return View(testC);
        }

        // GET: TestCs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TestCs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,IsActive,Age,Created,Updated")] TestC testC)
        {
            if (ModelState.IsValid)
            {
                db.Tests.Add(testC);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(testC);
        }

        // GET: TestCs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestC testC = db.Tests.Find(id);
            if (testC == null)
            {
                return HttpNotFound();
            }
            return View(testC);
        }

        // POST: TestCs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,IsActive,Age,Created,Updated")] TestC testC)
        {
            if (ModelState.IsValid)
            {
                db.Entry(testC).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(testC);
        }

        // GET: TestCs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestC testC = db.Tests.Find(id);
            if (testC == null)
            {
                return HttpNotFound();
            }
            return View(testC);
        }

        // POST: TestCs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TestC testC = db.Tests.Find(id);
            db.Tests.Remove(testC);
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

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DoQuangMinh_2210900042_Project2.Models;

namespace DoQuangMinh_2210900042_Project2.Controllers
{
    public class PHIEU_GIAM_GIAController : Controller
    {
        private DoQuangMinh_2210900042_prj2Entities db = new DoQuangMinh_2210900042_prj2Entities();

        // GET: PHIEU_GIAM_GIA
        public ActionResult Index()
        {
            return View(db.PHIEU_GIAM_GIA.ToList());
        }

        // GET: PHIEU_GIAM_GIA/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PHIEU_GIAM_GIA pHIEU_GIAM_GIA = db.PHIEU_GIAM_GIA.Find(id);
            if (pHIEU_GIAM_GIA == null)
            {
                return HttpNotFound();
            }
            return View(pHIEU_GIAM_GIA);
        }

        // GET: PHIEU_GIAM_GIA/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PHIEU_GIAM_GIA/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Ma_PGG,Ma_GG,So_tien_giam,Ngay_het_han,Trang_thai")] PHIEU_GIAM_GIA pHIEU_GIAM_GIA)
        {
            if (ModelState.IsValid)
            {
                db.PHIEU_GIAM_GIA.Add(pHIEU_GIAM_GIA);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pHIEU_GIAM_GIA);
        }

        // GET: PHIEU_GIAM_GIA/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PHIEU_GIAM_GIA pHIEU_GIAM_GIA = db.PHIEU_GIAM_GIA.Find(id);
            if (pHIEU_GIAM_GIA == null)
            {
                return HttpNotFound();
            }
            return View(pHIEU_GIAM_GIA);
        }

        // POST: PHIEU_GIAM_GIA/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Ma_PGG,Ma_GG,So_tien_giam,Ngay_het_han,Trang_thai")] PHIEU_GIAM_GIA pHIEU_GIAM_GIA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pHIEU_GIAM_GIA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pHIEU_GIAM_GIA);
        }

        // GET: PHIEU_GIAM_GIA/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PHIEU_GIAM_GIA pHIEU_GIAM_GIA = db.PHIEU_GIAM_GIA.Find(id);
            if (pHIEU_GIAM_GIA == null)
            {
                return HttpNotFound();
            }
            return View(pHIEU_GIAM_GIA);
        }

        // POST: PHIEU_GIAM_GIA/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PHIEU_GIAM_GIA pHIEU_GIAM_GIA = db.PHIEU_GIAM_GIA.Find(id);
            db.PHIEU_GIAM_GIA.Remove(pHIEU_GIAM_GIA);
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

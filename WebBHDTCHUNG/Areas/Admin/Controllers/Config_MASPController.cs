using PagedList;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebBHDTCHUNG.Models;
using WebBHDTCHUNG.Utils;

namespace WebBHDTCHUNG.Areas.Admin.Controllers
{
    public class Config_MASPController : Controller
    {
        private CMSBHDTCHUNGEntities db = new CMSBHDTCHUNGEntities();

        // GET: Admin/Config_MASP
        public ActionResult Index(int? page)
        {

            int pageSize = 20;
            int pageNumber = (page ?? 1);
            var model = db.Config_MASP.OrderBy(m => m.Id).ToList();

            return View(model.ToPagedList(pageNumber, pageSize));
        }


        // GET: Admin/Config_MASP/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Config_MASP/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CfMaSP")] Config_MASP config_MASP)
        {
            if (ModelState.IsValid)
            {
                db.Config_MASP.Add(config_MASP);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(config_MASP);
        }


        // GET: Admin/Config_MASP/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Config_MASP config_MASP = db.Config_MASP.Find(id);
            if (config_MASP == null)
            {
                return HttpNotFound();
            }
            return View(config_MASP);
        }

        // POST: Admin/Config_MASP/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Config_MASP config_MASP = db.Config_MASP.Find(id);
            db.Config_MASP.Remove(config_MASP);
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

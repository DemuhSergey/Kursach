using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Net;
using System.Data.Entity;
using ClassLibraryEF;
using Kursach.Models;
using ClassLibraryEF.Services;
using Kursach.Services.Builders;

namespace Kursach.Controllers
{
    public class ContentController : Controller
    {
        NewsDBProvider dbprovider = new NewsDBProvider();
        ContetBuilder cbuilder = new ContetBuilder();
        emploeeEF db = new emploeeEF();
        public ActionResult Index()
        {
            return View(dbprovider.Index());
        }
        public ActionResult Hockey()
        {
            return View(dbprovider.Hockey());
        }
        public ActionResult Football()
        {
            return View(dbprovider.Football());
        }
        public ActionResult Box()
        {
            return View(dbprovider.Box());
        }
        public ActionResult Create()
        {
            ViewBag.IdSport = new SelectList(db.TypeSports, "Id", "SportName");
            return View();
        }
        [HttpPost]
        public ActionResult Create(ContentViewModel contentTable, HttpPostedFileBase uploadImage)
        {
            var content = dbprovider.Add(cbuilder.CBuilder(contentTable), uploadImage);
            if (content != null)
            {
               return Redirect("/Content/Index");
            }
            ModelState.AddModelError("", "login and password is incorect");
            return View(contentTable);
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            return View(dbprovider.GetDelete(id));
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
             dbprovider.DeleteArticle(id);
             return RedirectToAction("Index");
        }
    }
}
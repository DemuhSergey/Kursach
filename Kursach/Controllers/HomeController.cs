using Kursach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kursach.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Football()
        {
           // var model = new NewsModel();
          //model.News = repo.getNews('football');
            return View();
        }
        public ActionResult Hockey()
        {
            return View();
        }
        public ActionResult Box()
        {
            return View();
        }
    }
}
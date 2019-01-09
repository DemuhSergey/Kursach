using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassLibraryEF;
using Kursach.Models;
using ClassLibraryEF.Services;
using Kursach.Services.Builders;

namespace Kursach.Controllers
{
    public class AccountController : Controller
    {
        UserRepository userRepository = new UserRepository();
        UserBuilder userBuilder = new UserBuilder();

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(UserViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = userRepository.Add(userBuilder.Build(userViewModel));
                if (user != null) {
                    Session["Id"] = user.Id.ToString();
                    Session["Name"] = user.Firstname.ToString();
                    Session["Role"] = user.Login.ToString();
                    return RedirectToAction("Index", "Content");
                }
            }
            return View(userViewModel);
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel loginViewModel)
        {
            var user = userRepository.Find(loginViewModel.Login, loginViewModel.Pasword);
            if (user != null) {
                Session["Id"] = user.Id.ToString();
                Session["Name"] = user.Firstname.ToString();
                Session["Role"] = user.Login.ToString();
                return Redirect("/Content/Index");
            }
            return View();
 
        }
	}
}
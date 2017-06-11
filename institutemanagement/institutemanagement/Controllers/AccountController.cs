using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using institutemanagement.DAL;
using institutemanagement.Models;

namespace institutemanagement.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        #region user registration
        [AllowAnonymous]
        public ActionResult Register()
        {
            Registerviewmodel model = new Registerviewmodel();
            model.UserType = 2;
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Register(Registerviewmodel model,string returnurl)
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }
        #endregion
    }
}
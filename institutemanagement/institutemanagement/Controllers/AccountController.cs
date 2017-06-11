using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using institutemanagement.DAL;
using institutemanagement.Models;
using institutemanagement.Repository;
using institutemanagement.Utility;

namespace institutemanagement.Controllers
{
    public class AccountController : Controller
    {
        public GenericUnitOfWork _unitOfWork = new GenericUnitOfWork();
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
                Member mem = new Member();
                mem.MemberName = model.MemberName;
                mem.LastName = model.LastName;
                mem.UserName = model.UserName;
                mem.CreatedOn = DateTime.Now;
                
                mem.Password = EncryptDecrypt.Encrypt(model.Password, true);
                mem.IsActive = true;
                
                _unitOfWork.GetRepositoryInstance<Member>().Add(mem);
                return RedirectToAction("Index", "Home");
            }
            return View("Register", model);
        }
        #endregion
    }
}
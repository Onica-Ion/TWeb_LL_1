using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TWeb_LL_1.BusinessLogic.Interfaces;
using TWeb_LL_1.BusinessLogic;
using TWeb_LL_1.Domain.Entities.User;
using TWeb_LL_1.Models;

namespace TWeb_LL_1.Controllers
{
    public class LoginController : Controller
    {
          private readonly ISession _session;
          public LoginController()
          {
               var bl = new BussinesLogic();
               _session = bl.GetSessionBL();
          }

          public ActionResult Index()
          {
               return View();
          }

          [HttpPost]
          [ValidateAntiForgeryToken]
          public ActionResult Index(UserLogin login)
          {
               if (ModelState.IsValid)
               {
                    ULoginData data = new ULoginData
                    {
                         Credential = login.Credential,
                         Password = login.Password,
                         LoginIp = Request.UserHostAddress,
                         LoginDateTime = DateTime.Now
                    };

                    var userLogin = _session.UserLogin(data);
                    /*if (userLogin.Status)
                    {
                         return RedirectToAction("Index", "Home");    
                    }
                    else
                    {
                         ModelState.AddModelError("", userLogin.StatusMsg);
                         return View();
                    }*/
               }
               return View();
          }
    }
}
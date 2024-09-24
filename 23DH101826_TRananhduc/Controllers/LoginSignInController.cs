using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _23DH101826_TRananhduc.Controllers
{
    public class LoginSignInController : Controller
    {
        // GET: LoginSignIn
        
        public ActionResult Index()
        {
            return View();
        }

       
        public ActionResult Login()
        {
            
            return View();
        }

        public ActionResult Signup()
        {
            return View();
        }
    }
}
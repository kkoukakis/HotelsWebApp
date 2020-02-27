using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
// using System.Security.Claims;
using HotelsWebApp.Models;

namespace HotelsWebApp.Controllers
{
    public class AccountController : Controller
    {

        private WdaContext _users;


        public AccountController(WdaContext context){
            _users = context;

        }

        public IActionResult Login()
        {
            if((string)ViewData["LoggedIn"] == "Y"){
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

         public IActionResult Logout()
        {
            if((string)ViewData["LoggedIn"] == "Y"){
                ViewData["LoggedIn"] = "N"; 
                return RedirectToAction("Index", "Home");
            }else{
                return RedirectToAction("Login", "Account");
           
            }
        }
        // protected int GetUserId() => this.User.Identity.IsAuthenticated
    }
}

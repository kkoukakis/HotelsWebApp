using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
// using System.Security.Claims;
using HotelsWebApp.Models;

namespace HotelsWebApp.Controllers
{
    public class HomeController : Controller
    {

        //In order to access DB
        private WdaContext _context;

        //Get Access to DB
        public HomeController(WdaContext context){
            _context = context;
        }


        public IActionResult Index()
        {

            var user = _context.User.First();
            ViewBag.User = user;
            ViewBag.User.Username = user.Username;  
            ViewBag.User.Email = user.Email;  
            ViewBag.Room = _context.Room;  
            ViewData["LoggedIn"]="Y";
            return View();  

            // return View(rooms);
        }

         public IActionResult Login()
        {
            if(ViewData["LoggedIn"]=="Y")
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

          public IActionResult Favorites()
        {
            return View();
        }
        
        // protected int GetUserId() => this.User.Identity.IsAuthenticated


        public IActionResult Room()
        {
            return View();
        }

        public IActionResult Roomlist()
        {
            var rooms = _context.Room;
            return View(rooms);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

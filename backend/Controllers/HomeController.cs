using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
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
            this._context = context;
        }


        public IActionResult Index()
        {
            var db = _context;
            var user = _context.User.First();

            ViewBag.User = user;
            ViewBag.User.Username = user.Username;  
            ViewBag.User.Email = user.Email;  
            return View(db);  
        }

         public IActionResult Login()
        {
            if((string)ViewData["LoggedIn"]=="Y")
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


        public IActionResult Room(int RoomId)
        {
            if(RoomId != 0){
                var db = _context.Room.Where(x => x.RoomId == RoomId).ToList();
                return View(db);
            }
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Roomlist(string city)
        {
            var db = _context;
            ViewBag.Room = _context.Room; 
            if(!string.IsNullOrEmpty(city)){
                ViewBag.Search = city;
                return View(db);
            }else{
              return View(db);
            }
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

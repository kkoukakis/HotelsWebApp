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
    public class HomeController : Controller
    {

        private WdaContext _context;


        public HomeController(WdaContext context){
            _context = context;
        }


        public IActionResult Index()
        {

            var room = _context.User;
            return View(room.First());
        }

         public IActionResult Login()
        {
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
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

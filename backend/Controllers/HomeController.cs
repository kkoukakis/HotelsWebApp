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
            ViewData["Search"] = "N";
            ViewBag.User = user;
            ViewBag.User.Username = user.Username;  
            ViewBag.User.Email = user.Email;  
            return View(db);  
        }

      

        [HttpPost]
         public IActionResult LoggedIn()
        {

            ViewData["LoggedIn"] = "Y";

            
            return RedirectToAction("Index", "Home");
           
        }



          public IActionResult Favorites()
        {
            return View();
        }
        
        public IActionResult Room(int RoomId)
        {
            ViewBag.ThisRoom = RoomId;
            if(RoomId != 0){
                var db = _context.Room.Where(x => x.RoomId == RoomId).ToList();
                if(db.Count !=0){
                ViewBag.Type = _context.RoomType.Where(x => x.id == db.First().RoomType).ToList().First();
                return View(db);
                }
            }
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Roomlist(string city, string roomType, string dateFROM, string dateTo, string priceFrom, string priceTill, string parking, string petfriendly, string wifi)
        {
            var db = _context;
             ViewData["Search"] = "Y";
            if(!string.IsNullOrEmpty(city))       {ViewBag.city = city;                                   ViewBag.lastsearch_city    = ViewBag.city        ;}
            if(!string.IsNullOrEmpty(roomType))   {ViewBag.roomtype = roomType;                           ViewBag.lastsearch_roomtype = ViewBag.roomType    ;}
            if(!string.IsNullOrEmpty(dateFROM))   {ViewBag.datefrom = dateFROM;                           ViewBag.lastsearch_datefrom = ViewBag.dateFROM    ;}
            if(!string.IsNullOrEmpty(dateTo))     {ViewBag.dateto = dateTo;                               ViewBag.lastsearch_dateto = ViewBag.dateto      ;}
            if(!string.IsNullOrEmpty(priceFrom))  {ViewBag.pricefrom = priceFrom;                         ViewBag.lastsearch_pricefrom = ViewBag.priceFrom   ;}
            if(!string.IsNullOrEmpty(priceTill))  {ViewBag.pricetill = priceTill;                         ViewBag.lastsearch_pricetill = ViewBag.priceTill   ;}
            if(!string.IsNullOrEmpty(parking))    {ViewBag.parking = parking == "on" ? "1" : "0";         ViewBag.lastsearch_parking = ViewBag.parking     ;}
            if(!string.IsNullOrEmpty(wifi))       {ViewBag.wifi = wifi == "on" ? "1" : "0";               ViewBag.lastsearch_wifi = ViewBag.wifi        ;}
            if(!string.IsNullOrEmpty(petfriendly)){ViewBag.petfriendly = petfriendly == "on" ? "1" : "0"; ViewBag.lastsearch_petfriendly = ViewBag.petfriendly ;}
            return View(db);
            
        }


        // Book room
        [HttpPost]
        public IActionResult Book(int RoomId , string CheckInDate, string CheckOutDate)
        {
           
                var entry = new Bookings
                {
                    RoomId = RoomId,
                    UserId = 1,
                    CheckInDate =  CheckInDate,
                    CheckOutDate = CheckOutDate,
                };
                _context.Bookings.Add(entry);
                _context.SaveChanges();

                return RedirectToAction("Index", "Home");
           
  
        }

        // Post Review
        [HttpPost]
        public IActionResult Review(int Rate , string Text, int RoomId)
        {
           
                var entry = new Reviews
                {
                    Rate = Rate,
                    Text = Text,
                    UserId =  1,
                    RoomId = RoomId,
                };
                _context.Reviews.Add(entry);
                _context.SaveChanges();

                return RedirectToAction("Room");
           
  
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

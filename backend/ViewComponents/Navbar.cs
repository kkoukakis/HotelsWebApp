using System.Linq;
using Microsoft.AspNetCore.Mvc;
using HotelsWebApp.Models;

namespace HotelsWebApp.ViewComponents
{
    public class Navbar : ViewComponent
    {
        private readonly WdaContext _context;

        public Navbar(WdaContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
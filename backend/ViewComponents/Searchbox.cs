using System.Linq;
using Microsoft.AspNetCore.Mvc;
using HotelsWebApp.Models;

namespace HotelsWebApp.ViewComponents
{
    public class Searchbox : ViewComponent
    {
        private readonly WdaContext _context;

        public Searchbox(WdaContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var cities = _context.Room
                .Select(i => i.City)
                .Distinct();

            return View();
        }
    }
}
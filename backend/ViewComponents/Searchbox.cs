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
            return View();
        }
    }
}
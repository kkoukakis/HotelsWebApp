using System.Linq;
using Microsoft.AspNetCore.Mvc;
using HotelsWebApp.Models;

namespace HotelsWebApp.ViewComponents
{
    public class Scripts : ViewComponent
    {
        private readonly WdaContext _context;

        public Scripts(WdaContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
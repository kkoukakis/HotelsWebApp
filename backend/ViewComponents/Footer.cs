using System.Linq;
using Microsoft.AspNetCore.Mvc;
using HotelsWebApp.Models;

namespace HotelsWebApp.ViewComponents
{
    public class Footer : ViewComponent
    {
        private readonly WdaContext _context;

        public Footer(WdaContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
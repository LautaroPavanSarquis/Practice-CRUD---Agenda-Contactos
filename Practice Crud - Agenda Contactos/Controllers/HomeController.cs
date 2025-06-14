using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Practice_Crud___Agenda_Contactos.Models;

namespace Practice_Crud___Agenda_Contactos.Controllers
{
    public class HomeController : Controller
    {
       private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
           _context = context; 
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Contact.ToListAsync());
        }

        public IActionResult Privacy()
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

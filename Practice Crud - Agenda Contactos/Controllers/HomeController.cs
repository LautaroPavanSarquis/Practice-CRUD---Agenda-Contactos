using System.Diagnostics;
using System.Threading.Tasks;
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

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Contact.ToListAsync());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken] //Anti ataques xss
        public async Task<IActionResult> Create(Contact contact)
        {
            if (ModelState.IsValid)
            {
                contact.CreatedDate = DateTime.Now; 

                _context.Contact.Add(contact);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null )
            {
                return NotFound();
            }

            var contact = _context.Contact.Find(id);
            if (contact == null) 
            { 
                return NotFound(); 
            }

            return View(contact);
        }

        [HttpPost]
        [ValidateAntiForgeryToken] 
        public async Task<IActionResult> Edit(Contact contact)
        {
            if (ModelState.IsValid)
            {
                _context.Update(contact);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = _context.Contact.Find(id);
            if (contact == null)
            {
                return NotFound();
            }

            return View(contact);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = _context.Contact.Find(id);
            if (contact == null)
            {
                return NotFound();
            }

            return View(contact);
        }

        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteContact(int? id)
        {
            var contact = await _context.Contact.FindAsync(id);

            if (contact == null)
            {
                return View();
            }

            _context.Contact.Remove(contact);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");   
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

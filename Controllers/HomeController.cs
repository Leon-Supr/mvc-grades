using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvc_grades.Models;
using Microsoft.EntityFrameworkCore;
using mvc_grades.Data;

namespace mvc_grades.Controllers;

public class HomeController : Controller
{
    private readonly MySQLDbContext _context;
    public HomeController(MySQLDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    // Mi codigo
    public async Task<IActionResult> ViewSubjects()
    {
        List<Subject> arrSubjects = await _context.Subjects.ToListAsync();
        return View(arrSubjects);
    }

    public IActionResult SubjectMuestra()
    {
        Subject subject = new Subject
        {
            id = 1,
            name = "Educación física"
        };
        // return Content("Hola!"); //Podemos retornar lo que se nos de la gana
        return View(subject);
    }

    public async Task<IActionResult> ViewSubject(int id)
    {
        Subject? subject = await _context.Subjects.FindAsync(id);
        if (subject == null)
        {
            return NotFound("No se encontró, lo siento mi loco");
        }
        return View("SubjectMuestra", subject);
    }

    // Crear
    [HttpGet]
    public IActionResult CreateSubject()
    {
        return View();
    }

    [HttpPost]
    // [ValidateAntiForgeryToken]
    public async Task<IActionResult> CreateSubject(Subject subject)
    {
        if (subject == null) return Error();
        if (ModelState.IsValid)
        {
            _context.Subjects.Add(subject);
            await _context.SaveChangesAsync();
            return RedirectToAction("ViewSubjects");
        }
        return View(subject);
    }

    //Modificar
    [HttpGet]
    public async Task<IActionResult> ModifySubject(int id)
    {
        Subject? subject = await _context.Subjects.FindAsync(id);
        if (subject == null) return NotFound();
        return View(subject);
    }

    [HttpPost]
    //[ValidateAntiForgeryToken] 
    public async Task<IActionResult> ModifySubject(Subject subject)
    {
        if (ModelState.IsValid)
        {
            try
            {
                _context.Subjects.Update(subject);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) // `DbConcurrencyException` no existe en EF Core, este sí.
            {
                return Content("Error al modificar el subject. Puede que el registro haya sido modificado por otro usuario.");
            }
            return RedirectToAction("ViewSubjects");
        }
        return View(subject);
    }

    //Eliminar
    [HttpGet]
    public async Task<IActionResult> DeleteSubject(int id)
    {
        Subject? subject = await _context.Subjects.FindAsync(id);
        if (subject == null)
        {
            return NotFound();
        }
        return View(subject);
    }

    [HttpPost, ActionName("DeleteSubject")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> EliminacionConfirmada(int id)
    {
        var subject = await _context.Subjects.FindAsync(id);
        if (subject == null)
        {
            return NotFound();
        }

        _context.Subjects.Remove(subject);
        await _context.SaveChangesAsync();
        return RedirectToAction("ViewSubjects");
    }

    //Fin de mi código

    //ACtividades
    public async Task<IActionResult> Details(int id)
    {
        // Buscar la materia e incluir sus actividades
        var subject = await _context.Subjects
            .Include(s => s.Activities)  // Incluir las actividades asociadas
            .FirstOrDefaultAsync(s => s.id == id);  // Buscar por Id

        if (subject == null)
        {
            return NotFound();  // Si no se encuentra la materia
        }

        return View(subject);  // Pasar la materia con sus actividades a la vista
    }




    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

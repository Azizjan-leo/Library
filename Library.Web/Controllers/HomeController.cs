using Library.Web.Data;
using Library.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Library.Web.Controllers;

public class HomeController : Controller
{
    private readonly ApplicationDbContext _context;

    public HomeController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var user = await _context.Users
            .Include(x => x.ReadBooks)
            .FirstAsync(x => x.UserName == "Zarina");

        var books = await _context.Books
            .Include(x => x.Author)
            .OrderBy(x => x.Title)
            .ToListAsync();
        
        user.ReadBooks.Add(books.First(x => x.Id == 1));

        await _context.SaveChangesAsync();

        return View(books);
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

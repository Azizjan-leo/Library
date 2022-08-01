using Library.Web.Data;
using Library.Web.Models;
using Microsoft.AspNetCore.Authorization;
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
        var query = $@"select b.*, 
            case when coalesce(ub.""PplWhoReadId"", 'null') = 
              (select ""Id""
            from ""AspNetUsers"" u
            where u.""UserName"" = '{User.Identity.Name}')
            then true else false end as ""Read""
            from ""Books"" b
            left join ""ApplicationUserBook"" ub on b.""Id"" = ub.""ReadBooksId""";

        var books = await _context.ReadBooks
         .FromSqlRaw(query)
         .OrderBy(x => x.Title)
         .ToListAsync();

        return View(books);
    }

    [Authorize]
    public async Task<JsonResult> AddToReadList(int bookId)
    {
        var query = $@"insert into ""ApplicationUserBook"" (""PplWhoReadId"", ""ReadBooksId"")
            values(
            (select ""Id""
            from ""AspNetUsers"" u
            where u.""UserName"" = '{User.Identity.Name}'), {bookId})";

        int noOfRowUpdated = await _context.Database.ExecuteSqlRawAsync(query);
      
        return Json(noOfRowUpdated);
    }
    
    [Authorize]
    public async Task<JsonResult> RemoveFromReadList(int bookId)
    {
        var query = $@"delete from ""ApplicationUserBook"" 
            where ""PplWhoReadId"" = 
            (select ""Id""
            from ""AspNetUsers"" u
            where u.""UserName"" = '{User.Identity.Name}')
            and ""ReadBooksId"" = {bookId}";

        int noOfRowUpdated = await _context.Database.ExecuteSqlRawAsync(query);
      
        return Json(noOfRowUpdated);
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

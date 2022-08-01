using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Library.Web.Data;

public class ApplicationUser : IdentityUser
{
    public ICollection<Book> ReadBooks { get; set; } = new HashSet<Book>();
}

using System.ComponentModel.DataAnnotations;

namespace Library.Web.Data;

public class Book
{
    public int Id { get; set; }

    [Required]
    [MaxLength(256)]
    public string Title { get; set; } = string.Empty;

    public int AuthorId { get; set; }

    public virtual Writer Author { get; set; }

    [Required]
    public string Description { get; set; }

    public virtual List<ApplicationUser> PplWhoRead { get; set; }
}

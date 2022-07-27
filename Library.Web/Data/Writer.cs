using System.ComponentModel.DataAnnotations;

namespace Library.Web.Data;

public class Writer
{
    public int Id { get; set; }

    [Required]
    [MaxLength(256)]
    public string Name { get; set; }

    public virtual ICollection<Book> Books { get; set; }
}

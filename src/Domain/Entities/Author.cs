using System.Collections.Generic;

namespace Domain.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? MiddleName { get; set; }
        public string? Bio { get; set; }
        public ICollection<BookAuthor> Books { get; set; } = new List<BookAuthor>();
    }
}

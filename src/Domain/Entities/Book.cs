using System.Collections.Generic;

namespace Domain.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Ibn { get; set; }
        public string Abstract { get; set; }
        public int Year { get; set; }
        public string Publisher { get; set; }
        public ICollection<Page> Pages { get; set; } = new List<Page>();
        public ICollection<BookFileFormat> AvailableFormats { get; set; } = new List<BookFileFormat>();
        public ICollection<BookAuthor> Authors { get; set; } = new List<BookAuthor>();
    }
}

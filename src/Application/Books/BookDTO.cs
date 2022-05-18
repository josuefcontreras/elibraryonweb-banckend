using Application.Authors;
using Application.FileFormats;
using System.Collections.Generic;

namespace Application.Books
{
    public class BookDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Ibn { get; set; }
        public string Abstract { get; set; }
        public int Year { get; set; }
        public string Publisher { get; set; }
        public List<FileFormatDTO> AvailableFormats { get; set; } = new List<FileFormatDTO>();
        public List<AuthorDTO> Authors { get; set; } = new List<AuthorDTO>();
    }
}

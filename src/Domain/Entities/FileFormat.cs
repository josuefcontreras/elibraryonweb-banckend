using System.Collections.Generic;

namespace Domain.Entities
{
    public class FileFormat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Extention { get; set; }
        public ICollection<BookFileFormat> Books { get; set; } = new List<BookFileFormat>();
    }
}

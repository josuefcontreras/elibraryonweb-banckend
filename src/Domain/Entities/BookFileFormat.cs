namespace Domain.Entities
{
    public class BookFileFormat
    {
        public int FileFormatId { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public FileFormat FileFormat { get; set; }
    }
}

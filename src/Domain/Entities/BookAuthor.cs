namespace Domain.Entities
{
    public class BookAuthor
    {
        public int AuthorId { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public Author Author { get; set; }
    }
}

namespace Domain.Entities
{
    public class Page
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool Ismain { get; set; }
        public int Number { get; set; }
        public string? Content { get; set; }
        public Book Book { get; set; }
    }
}

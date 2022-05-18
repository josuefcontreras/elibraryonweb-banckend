using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class BookAuthorConfiguration : IEntityTypeConfiguration<BookAuthor>
    {
        public void Configure(EntityTypeBuilder<BookAuthor> builder)
        {
            builder.HasKey(ba => new { ba.BookId, ba.AuthorId });

            builder.HasOne(bookAuthor => bookAuthor.Book)
                .WithMany(book => book.Authors)
                .HasForeignKey(bookAuthor => bookAuthor.BookId);

            builder.HasOne(bookAuthor => bookAuthor.Author)
                .WithMany(author => author.Books)
                .HasForeignKey(bookAuthor => bookAuthor.AuthorId);
        }
    }
}

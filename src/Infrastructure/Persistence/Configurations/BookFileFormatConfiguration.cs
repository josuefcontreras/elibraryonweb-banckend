using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    internal class BookFileFormatConfiguration : IEntityTypeConfiguration<BookFileFormat>
    {
        public void Configure(EntityTypeBuilder<BookFileFormat> builder)
        {
            builder.HasKey(bf => new { bf.BookId, bf.FileFormatId });

            builder.HasOne(bookFileFormat => bookFileFormat.Book)
                .WithMany(book => book.AvailableFormats)
                .HasForeignKey(bookFileFormat => bookFileFormat.FileFormatId);

            builder.HasOne(bookFileFormat => bookFileFormat.FileFormat)
                .WithMany(fileFormat => fileFormat.Books)
                .HasForeignKey(bookFileFormat => bookFileFormat.BookId);
        }
    }
}

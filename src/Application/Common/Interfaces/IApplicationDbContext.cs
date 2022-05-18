using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        public DbSet<AppUser> Users { get; }
        public DbSet<Author> Authors { get; }
        public DbSet<Book> Books { get; }
        public DbSet<BookAuthor> BookAuthors { get; }
        public DbSet<BookFileFormat> BookFileFormats { get; }
        public DbSet<FileFormat> FileFormats { get; }
        public DbSet<Page> Pages { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        public EntityEntry Entry(object entity);
    }
}

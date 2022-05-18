
using Application.Common.Interfaces;
using Application.Common.Models;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Books
{
    public class Details
    {
        public class Query : IRequest<Result<BookDTO>>
        {
            public int bookId { get; set; }
        }
        public class Handler : IRequestHandler<Query, Result<BookDTO>>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public Handler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }
            public async Task<Result<BookDTO>> Handle(Query request, CancellationToken cancellationToken)
            {
                var book = await _context.Books
                    .ProjectTo<BookDTO>(_mapper.ConfigurationProvider)
                    .FirstOrDefaultAsync(x => x.Id == request.bookId, cancellationToken);

                return Result<BookDTO>.Success(book);
            }
        }
    }
}

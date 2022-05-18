using Application.Common.Interfaces;
using Application.Common.Models;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Books
{
    public class List
    {
        public class Query : IRequest<Result<PagedList<BookDTO>>>
        {
            public BookParams PagingParams { get; set; }
        }
        public class Handler : IRequestHandler<Query, Result<PagedList<BookDTO>>>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public Handler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<Result<PagedList<BookDTO>>> Handle(Query request, CancellationToken cancellationToken)
            {
                var query = _context.Books
                    .ProjectTo<BookDTO>(_mapper.ConfigurationProvider);

                var books = await PagedList<BookDTO>.CreateAsync(query, request.PagingParams.PageNumber, request.PagingParams.Pagesize);

                return Result<PagedList<BookDTO>>.Success(books);
            }
        }
    }

}

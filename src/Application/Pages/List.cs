using Application.Common.Interfaces;
using Application.Common.Models;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Pages
{
    public class List
    {
        public class Query : IRequest<Result<PagedList<PageDTO>>>
        {
            public PageParams PageParams { get; set; }
        }
        public class Handler : IRequestHandler<Query, Result<PagedList<PageDTO>>>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public Handler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<Result<PagedList<PageDTO>>> Handle(Query request, CancellationToken cancellationToken)
            {
                var query = _context.Pages.Where(p => p.Book.Id == request.PageParams.BookId)
                    .ProjectTo<PageDTO>(_mapper.ConfigurationProvider);

                var page = await PagedList<PageDTO>.CreateAsync(query, request.PageParams.PageNumber, request.PageParams.Pagesize);

                return Result<PagedList<PageDTO>>.Success(page);
            }
        }
    }

}

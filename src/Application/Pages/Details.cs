
using Application.Common.Interfaces;
using Application.Common.Models;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Pages
{
    public class Details
    {
        public class Query : IRequest<Result<PageDTO>>
        {
            public int pageId { get; set; }
        }
        public class Handler : IRequestHandler<Query, Result<PageDTO>>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public Handler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }
            public async Task<Result<PageDTO>> Handle(Query request, CancellationToken cancellationToken)
            {
                var page = await _context.Books
                    .ProjectTo<PageDTO>(_mapper.ConfigurationProvider)
                    .FirstOrDefaultAsync(x => x.Id == request.pageId, cancellationToken);

                return Result<PageDTO>.Success(page);
            }
        }
    }
}

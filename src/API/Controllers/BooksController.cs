using Application.Books;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class BooksController : BaseApiController
    {

        // GET: api/<BooksController>
        [HttpGet]
        public async Task<IActionResult> GetBooks([FromQuery] BookParams pagingParams)
        {
            var request = new List.Query() { PagingParams = pagingParams };
            var result = await Mediator.Send(request);
            return HandlePagedResult(result);
        }

        // GET api/<BooksController>/5
        [HttpGet("{bookId}")]
        public async Task<IActionResult> GetBookById(int bookId)
        {
            var request = new Details.Query() { bookId = bookId };
            var result = await Mediator.Send(request);
            return HandleResult(result);
        }
    }
}

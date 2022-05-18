using Application.Pages;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class PagesController : BaseApiController
    {

        // GET: api/<PagesController>
        [HttpGet]
        public async Task<IActionResult> GetPagesByBookId([FromQuery] PageParams pageParams)
        {
            var request = new List.Query() { PageParams = pageParams };
            var result = await Mediator.Send(request);
            return HandlePagedResult(result);
        }

        // GET api/<PagesController>/5
        [HttpGet("{pageId}")]
        public async Task<IActionResult> GetPageById(int pageId)
        {
            var request = new Details.Query() { pageId = pageId };
            var result = await Mediator.Send(request);
            return HandleResult(result);
        }
    }
}

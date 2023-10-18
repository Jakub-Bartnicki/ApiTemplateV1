using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Clean.Api.Controllers
{
    public class CleanController : BaseController<CleanController>
    {
        public CleanController(ILogger<CleanController> logger, IMediator mediator) : base(logger, mediator)
        { }

        [HttpGet]
        public Task<IActionResult> GetExampleResponse()
        {
            var query = new ExampleQuery();
        }
    }
}

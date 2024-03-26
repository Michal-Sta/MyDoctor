using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MyDoctor.Infrastructure.API
{
    [ApiController]
    [Route("/api/[controller]")]
    public class BaseController : Controller
    {
        public readonly IMediator mediator;

        public BaseController(IMediator mediator)
        {
            this.mediator = mediator;
        }
    }
}

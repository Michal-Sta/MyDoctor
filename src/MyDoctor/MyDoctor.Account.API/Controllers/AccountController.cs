using MediatR;
using Microsoft.AspNetCore.Mvc;
using MyDoctor.Infrastructure.API;

namespace MyDoctor.Auth.API.Controllers
{
    public class AccountController : BaseController
    {
        public AccountController(IMediator mediator) : base(mediator)
        {
        }

        public async Task<IActionResult> Get()
        {
            return NoContent();
        }

        public async Task<IActionResult> Register()
        {
            return NoContent();
        }

        public async Task<IActionResult> SignIn()
        {
            return NoContent();
        }

        public async Task<IActionResult> SignOut()
        {
            return NoContent();
        }
    }
}

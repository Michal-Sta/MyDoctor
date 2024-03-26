using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyDoctor.Infrastructure.API;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDoctor.Auth.API.Controllers
{
    public class PasswordController : BaseController
    {
        public PasswordController(IMediator mediator) : base(mediator)
        {
        }


        [HttpPut]
        [Authorize]
        [SwaggerOperation("Change password for account")]
        public async Task<IActionResult> Change( )
        {
            return NoContent();
        }

    }
}

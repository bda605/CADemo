using CADemo.Application.Common.Handler;
using CADemo.Application.User.LoginUser;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CADemo.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task <ActionResult<Result<string>>> LoginUser(LoginUserCommand command) 
        {
            return await _mediator.Send(new LoginUserCommand { Email = command.Email, Password = command.Password });
        }
    }
}

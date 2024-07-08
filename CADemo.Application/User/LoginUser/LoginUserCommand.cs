using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CADemo.Application.Common.Handler;
using MediatR;

namespace CADemo.Application.User.LoginUser
{
    public class LoginUserCommand:IRequest<Result<string>>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}

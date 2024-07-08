using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CADemo.Application.Common.Handler;
using CADemo.Application.Interface;

namespace CADemo.Application.User.LoginUser
{
    public class LoginUserHandler : IRequestHandler<LoginUserCommand, Result<string>>
    {
        private readonly IUserRepository _userRepository;

        public LoginUserHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        
        public async Task<Result<string>> Handle(LoginUserCommand request, CancellationToken cancellationToken)
        {
            var user = _userRepository.GetByUser(request.Email, request.Password);
            if (user == null)
            {
                return Result<string>.BadRequest(new string[] { "Login Fail" });
            }
            return Result<string>.Ok("Login Success");
           
        }
    }
}

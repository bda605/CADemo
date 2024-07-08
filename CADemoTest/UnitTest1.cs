using CADemo.Application.Interface;
using CADemo.Application.User.LoginUser;
using CADemo.Domain.Entitie;
using Microsoft.Extensions.DependencyInjection;
using NSubstitute;
using NSubstitute.ReturnsExtensions;

namespace CADemoTest
{
    public class Tests
    {
        private IUserRepository _userRepository;
        [SetUp]
        public void Setup()
        {
            _userRepository = Substitute.For<IUserRepository>();
           
        }

        [Test]
        public void LoginSuccess()
        {
            var LoginUserHandler = new LoginUserHandler(_userRepository);
            _userRepository.GetByUser("test", "test").Returns(  new User { Email = "test1", Password = "test1" });
            var result = LoginUserHandler.Handle(new LoginUserCommand { Email = "test", Password = "test" }, CancellationToken.None);
            Assert.AreEqual("Login Success", result.Result.Data);
        }

        [Test]
        public void LoginFail()
        {
            var LoginUserHandler = new LoginUserHandler(_userRepository);
            _userRepository.GetByUser("test", "test").ReturnsNull();
            var result = LoginUserHandler.Handle(new LoginUserCommand { Email = "test", Password = "test" }, CancellationToken.None);
            Assert.AreEqual("Login Fail", result.Result.Errors[0]);
        }

    }
}
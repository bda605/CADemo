using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CADemo.Application.Interface;
using CADemo.Domain.Entitie;

namespace CADemo.Persistence.Repository
{
    public class UserRepository:IUserRepository
    {
        private List<User> _users = new List<User>
        {
            new User
            {
                Email = "admin",
                Password = "123456"
            }
        };
        public User GetByUser(string email, string password)
        {
           return  _users.Where(x=>x.Email == email && x.Password == password).FirstOrDefault();
        }
    }
}

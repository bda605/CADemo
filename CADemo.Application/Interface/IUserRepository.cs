using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CADemo.Domain.Entitie;
namespace CADemo.Application.Interface
{
    public interface IUserRepository
    {
       Domain.Entitie.User GetByUser(string email, string password);
    }
}

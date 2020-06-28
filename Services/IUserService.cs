
using jm_web_api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jm_web_api.Services
{
    public interface IUserService
    {
         User Authenticate(string username, string password);
         IEnumerable<User> GetAll();
         User GetById(int id);
         User Create(User user, string password);
         void Update(User user, string password = null);
         void Delete(int id);
    }
}

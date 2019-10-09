using DbTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbTest.Repository
{
    public interface IUserRepository : IRepository<User>
    {
        IEnumerable<User> GetAllUser();
        bool AddUser(User user);
        User FindById(int id);
        User UpdateUser(int id,User user);
        bool DeleteUser(int id);
    }
}

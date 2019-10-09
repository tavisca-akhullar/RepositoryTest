using DbTest.Models;
using DbTest.Utility;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbTest.Repository
{
    public class UserService:MySQLRepository<User>,IUserRepository    
    {
        private NLog.Logger _logger;

        public UserService(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
            _logger = NLog.LogManager.GetCurrentClassLogger();
        }

        public bool AddUser(User user)
        {
            _logger.Info("Adding user "+user.Name);
            return Create(user);
        }

        public bool DeleteUser(int id)
        {
            _logger.Info("Deleting user with id " + id);
            return Delete(id);
        } 

        public User FindById(int id)
        {
            return Find(id);
        }

        public IEnumerable<User> GetAllUser()
        {
            return FindAll().ToList();
        }

        public User UpdateUser(int id, User user)
        {
            _logger.Info("Updating user with name " + user.Name);
            var u = Find(id);
            u.Name = user.Name;
            u.Email = user.Email;
            Update(u);
            return u;
        }
    }
}

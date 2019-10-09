using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DbTest.Repository;
using DbTest.Utility;

namespace DbTest.Service
{
    public class UserConfiguration : IUserService
    {
        private RepositoryContext _repoContext;
        private IUserRepository _user;
        public IUserRepository User
        {
            get
            {
                if (_user == null)
                {
                    _user = new UserService(_repoContext);
                }

                return _user;
            }
        }

        public UserConfiguration(RepositoryContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }


        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
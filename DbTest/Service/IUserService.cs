using DbTest.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbTest.Service
{
   public interface IUserService
    {
        IUserRepository User { get;  }
        void Save();
    }
}